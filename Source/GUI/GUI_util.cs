using PosmosVV.Proc;
using System;
using System.Collections.Generic;
using System.Drawing.Drawing2D;

namespace PosmosVV.GUI
{
    class GUI_util
    {
        public List<float> res;
        public List<int> inds;
        public void Compare(float X, float Y, float centerX, float centerY, float scale, PosmosVV.Proc.Galaxy galaxy, int galaxySize)
        {
            scale *= 4;
            res = new List<float>();
            inds = new List<int>();
            float Xorig = (float)(X - centerX) / scale;
            float Yorig = (float)(Y - centerY) / scale;
            int integ = 0;
            float maxOffset = 10f / scale;

            for (int i = 0; i < galaxy.systems.Count; i++)
            {
                if (Math.Abs(Xorig - galaxy.systems[i].coordinates[0]) < maxOffset && Math.Abs(Yorig - galaxy.systems[i].coordinates[1]) < maxOffset)
                {
                    integ += i;
                    float Xdelta = Math.Abs(Xorig - galaxy.systems[i].coordinates[0]);
                    float Ydelta = Math.Abs(Yorig - galaxy.systems[i].coordinates[1]);
                    res.Add(Xdelta + Ydelta);
                    inds.Add(i);
                }
            }

            if (integ != 0)
            {
                float winner = res.Min();
                int winnerIndex = res.IndexOf(winner);
                int winnerwinner = inds[winnerIndex];
                var systemu = galaxy.systems[winnerwinner];
                //MessageBox.Show($"we chose {winner}");
                Form2 display = new Form2();
                display.temp = (int)systemu.Primary_bodies[0].temperature;
                display.size = systemu.Primary_bodies[0].size;
                display.bodies = systemu.Primary_bodies.Count;
                display.inder = winnerwinner;
                display.gtrackerbar = galaxySize;

                display.coordis[0] = systemu.coordinates[0];
                display.coordis[1] = systemu.coordinates[1];
                display.unscaled[0] = (float)systemu.coordinates[0] / galaxySize;
                display.unscaled[1] = (float)(systemu.coordinates[1] / galaxySize);
                display.superserious_function(galaxy);
                display.ShowDialog();
                
            }
            else
            {
                DialogResult resul = MessageBox.Show("There's no star in these coordinates", "airball", MessageBoxButtons.OK);
            }
        }

    }
}
