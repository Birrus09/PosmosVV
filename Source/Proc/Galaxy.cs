using System.Collections.Generic;
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

    public void FindType()
        {

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
                b.distance = (int)RandomGen.IntervalF(0.83f, 1.24f, ref seed) * i * 100; // orbit goes from +distance to -distance
                b.coords = new int[2];
                b.coords[0] = 0;
                b.coords[1] = b.distance;
                b.id = 1;
                b.size = RandomGen.Interval(70, 300, ref seed);
                if (RandomGen.Chance(0.20f, ref seed))
                {
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


                b.FindType();

                Primary_bodies.Add(b);
            }
  
            
        }

}



class Galaxy
{
    public List<System> systems;


    public void GenerateGalaxy(int seed, int size = 1000)
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
                    s.coordinates[0] = (int)(i * Math.Cos((double)i/RandomGen.IntervalF(0.9995f, 1.0008f, ref seed)));
                    s.coordinates[1] = (int)(i * Math.Sin((double)i/RandomGen.IntervalF(0.9995f, 1.0008f, ref seed)));
                    systems.Add(s);
                }

                
            }

        }
    }
}
}
