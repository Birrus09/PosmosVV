using System.Collections.Generic;
using static System.ComponentModel.Design.ObjectSelectorEditor;
namespace PosmosVV.Proc
{


    public class Body
    {
        public int id;
        public int[] coords;
        public string type;
        public int size;
        public float temperature;
        public int magnetic_field;
        public float rotation_speed;
        public float revolution_speed;
        public List<Body> Orbits;
        public int distance;
        public bool hasOrbitals = false;

        public void FindType(ref int seed)
        {
            double xpol = temperature / 400.0f;
            double ypol = RandomGen.IntervalF(-50.0f, 50.0f, ref seed);
            //             rocky
            //  temp --------------------- >
            //hum
            // |  barren    arid      molten
            // |
            // |
            // |   tundra   gaia      primworld
            // |
            // |
            // |   frozen   tropical   stormworld
            // V
            if (magnetic_field / size > 0.9 && size > 400)
            {
                type = "gas giant";
                return;
            }

            if (xpol > 10.0f)
            {
                if (ypol > 10.0f)
                {
                    type = "stormworld";
                }
                if (ypol < -10.0f)
                {
                    type = "molten";
                }
                else
                {
                    type = "primworld";
                }
            }
            if (xpol < -10.0f)
            {
                if (ypol > 10.0f)
                {
                    type = "frozen";
                }
                if (ypol < -10.0f)
                {
                    type = "barren";
                }
                else
                {
                    type = "tundra";
                }

            }
            else
            {
                if (ypol > 10.0f)
                {
                    type = "tropical";
                }
                if (ypol < -10.0f)
                {
                    type = "arid";
                }
                else
                {
                    type = "gaia";
                }
            }
        }
    }

    public class Star : Body
    {
        public int out_temp;
        public int radiation;

        public void gen(ref int seed)
        {
            id = 1;
            coords = new int[2];
            coords[0] = 0;
            coords[1] = 0;
            size = RandomGen.Interval(100, 500, ref seed);
            temperature = RandomGen.IntervalF(3000.0f, 10000.0f, ref seed) * size * 2 / 500;
            out_temp = (int)temperature / 10;
            radiation = RandomGen.Interval(100, 10000, ref seed) * out_temp * size / 500;
        }

    }



    class System
    {

        public int sys_id;
        public List<Body> Primary_bodies; //no orbitals, they are inherited;
        public int[] coordinates;

        public void GenerateSystem(ref int seed)
        {
            sys_id = 1;
            Primary_bodies = new List<Body>();
            Star star = new Star();
            star.gen(ref seed);
            Primary_bodies.Add(star);

            //add smal chance for binary star system
            //TODO


            for (int i = 0; i < RandomGen.Interval(5, 12, ref seed); i++)
            {
                Body b = new Body();
                b.size = RandomGen.Interval(70, 300, ref seed);
                b.distance = (int)(((float)(Primary_bodies[i].size) / 150.0f) * (i+1) * 100); // orbit goes from +distance to -distance
                b.coords = new int[2];
                b.coords[0] = b.distance;
                b.coords[1] = 0;
                b.id = 1;
                if(i == 0)
                {
                    b.hasOrbitals = true;
                }
                if (RandomGen.Chance(0.20f, ref seed))
                {
                    b.hasOrbitals = true;
                    b.Orbits = new List<Body>();
                    for (int j = 0; j < RandomGen.Interval(1, 4, ref seed); j++)
                    {
                        Body o = new Body();
                        o.distance = (int)RandomGen.IntervalF(0.83f, 1.24f, ref seed) * j * 50;
                        o.size = RandomGen.Interval(20, 120, ref seed);
                        o.coords = new int[2];
                        o.coords[0] = 0;
                        o.coords[1] = o.distance;
                        o.type = "moon";
                        if (o.size > b.size * 0.5f)
                        {
                            o.type = "twin planet";
                            b.type = "twin planet";
                        }
                        else if (o.size > 70)
                        {
                            o.type = "orbital";
                        }
                        o.temperature = RandomGen.IntervalF(-20.0f, 20.0f, ref seed);
                        o.temperature = (b.temperature) * 0.3f + (star.out_temp - 5000.0f) * 0.4f;
                        b.Orbits.Add(o);
                    }
                }
                b.magnetic_field = (int)RandomGen.IntervalF(0.6f, 1.2f, ref seed) * b.size;
                b.revolution_speed = RandomGen.IntervalF(10.0f, 100.0f, ref seed);
                b.rotation_speed = RandomGen.IntervalF(0.1f, 1.0f, ref seed);


                b.temperature = RandomGen.IntervalF(-200.0f, 200.0f, ref seed);
                b.temperature = (b.temperature) * 0.4f + (star.out_temp - 5000.0f) * 0.6f;


                b.FindType(ref seed);

                Primary_bodies.Add(b);
            }


        }

    }



    class Galaxy
    {
        public List<System> systems;
        int starsize = 0;


        public void GenerateGalaxy(int seed, int size = 15000, float deviation = 0.0855f) //0-7
        {
            systems = new List<System>();
            // scatter spiral without central radius
            int central_radius = size / 10;
            for (int i = 0; i < size; i++)
            {
                if (Utility.IsPrime(i))
                {
                    if (i > central_radius)
                    {
                        System s = new System();
                        s.coordinates = new int[2];
                        s.coordinates[0] = (int)(i * Math.Cos((double)i / RandomGen.IntervalF(1.0f - 0.0001f * deviation, 1.0f + 0.0001f * deviation, ref seed)));
                        s.coordinates[1] = (int)(i * Math.Sin((double)i / RandomGen.IntervalF(1.0f - 0.0001f * deviation, 1.0f + 0.0001f * deviation, ref seed)));
                        s.GenerateSystem(ref seed);
                        if (Math.Sqrt(s.coordinates[0] * s.coordinates[0] + s.coordinates[1] * s.coordinates[1]) > central_radius)
                        {
                            systems.Add(s);
                            starsize++;
                        }
                       
                    }


                }

            }
        }

        public void GenerateGalaxy2(int seed, int size = 30000, float Spiral = 0.15f, float spread = 0.24f, float density = 0.27f)
        {
            systems = new List<System>();
            for (int i = 0; i < size; i++)
            {
                if (Utility.IsPrime(i) && !RandomGen.Chance((float)i/(2 * size * density), ref seed))
                {
                    float angle = i * Spiral + RandomGen.IntervalF(-spread, spread, ref seed);
                    System s = new System();
                    s.GenerateSystem(ref seed);
                    int central_radius = size / 40;
                    s.coordinates = new int[2];
                    s.coordinates[0] = (int)(i * Math.Cos(angle))/2;
                    s.coordinates[1] = (int)(i * Math.Sin(angle))/2;
                    if (Math.Sqrt(s.coordinates[0] * s.coordinates[0] + s.coordinates[1] * s.coordinates[1]) > central_radius)
                    {
                        systems.Add(s);
                        starsize++;
                    }
                }
               
            }
        }

    }
}
