namespace PosmosVV.Proc
{
    using System.Collections.Generic.List<T>;
using PosmosVV.Proc;

public class Body
{
    public int id;
    public int[2] coords;
    public string type;
    public int size;
    public float temperature;
    public int magnetic_field;
    public float rotation_speed;
    public float revolution_speed;
    public List<Body> Orbits;
    public int distance;

}

public class Star : Body
{
    public int out_temp;
    public int radiation;

}



class System
{

    public int sys_id;
    public List<Body> Primary_bodies; //no orbitals, they are inherited;
    public int[2] coordinates;

    public void GenerateSystem()
        {
            
        }

}



class Galaxy
{
    public List<System> systems;


    public void GenerateGalaxy(int seed, int size)
    {
        // scatter spiral
        for (int i = 0; i < 1000; i++)
        {
            System s = new System();
            s.coordinates[0] = i * cos((double)i/1.2);
            s.coordinates[0] = i * sin((double)i/1.2);

            systems.add(s);
        }
    }


}




}
