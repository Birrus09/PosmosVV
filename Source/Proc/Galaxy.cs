namespace PosmosVV.Proc
{
    using System.Collections.Generic;
using PosmosVV.Proc;

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

    public string FindType()
        {
            return type = "planet";
        }

}

public class Star : Body
{
    public int out_temp;
    public int radiation;

    public void gen()
        {
            id = 0xdeadbeef;
            coords = new int[2];
            coords[0] = 0;
            coords[1] = 0;
            size = RandomGen.Interval(100, 500, ref seed);
            temperature = RandomGen.IntervalF(3000.0f, 10000.0f, ref seed);
            out_temp = (int)temperature / 10;
            radiation = RandomGen.Interval(100, 10000, ref seed);
        }

}



class System
{

    public int sys_id;
    public List<Body> Primary_bodies; //no orbitals, they are inherited;
    public int[] coordinates;

    public void GenerateSystem(int seed)
        {
            sys_id = 0xdeadbeef;
            Primary_bodies = new List<Body>();
            Star star = new Star();
            star.gen();
            Primary_bodies.Add(star);
            for (int i = 0; i < RandomGen.Interval(5, 12, ref seed); i++)
            {
                Body b = new Body();
                b.distance = (int)randomgen.Intervalf(0.83, 1.24, ref seed) * i * 100; // orbit goes from +distance to -distance
                b.coords = new int[2];
                b.coords[0] = 0;
                b.coords[1] = b.distance;
                b.id = 0xdeadbeef;
                b.size = RandomGen.Interval(70, 300, ref seed);
                if (RandomGen.Chance(0.20, seed))
                {
                    b.Orbits = new List<Body>();
                    for (int j = 0; j < RandomGen.Interval(1, 4, ref seed); j++)
                    {
                        Body o = new Body();
                        o.distance = (int)randomgen.Intervalf(0.83, 1.24, ref seed) * j * 50; 
                        o.size = RandomGen.Interval(30, 70, ref seed);
                        o.coords = new int[2];
                        o.coords[0] = 0;
                        o.coords[1] = o.distance;
                    }
                }
                b.magnetic_field = RandomGen.Interval(50, 100, ref seed);
                b.revolution_speed = RandomGen.IntervalF(0.1f, 1.0f, ref seed);
                b.rotation_speed = RandomGen.IntervalF(0.1f, 1.0f, ref seed);
                b.temperature = RandomGen.IntervalF(-200.0f, 200.0f, ref seed);
                b.FindType();

                Primary_bodies.Add(b);
            }
  
            
        }

}



class Galaxy
{
    public List<System> systems = new List<System>();


    public void GenerateGalaxy(int seed, int size = 1000)
    {
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
                    s.coordinates[0] = (int)(i * Math.Cos((double)i/RandomGen.IntervalF(0.98, 1.12, seed)));
                    s.coordinates[1] = (int)(i * Math.Sin((double)i/RandomGen.IntervalF(0.98, 1.12, seed)));
                }

                systems.Add(s);
            }

        }


    }


}




}
