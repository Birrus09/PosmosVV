using PosmosVV.Proc;
using System;
using System.Collections.Generic;

namespace PosmosVV.GUI
{
    class GUI_util
    {
        public List<float> res;
        public List<int> inds;
        public void Compare(float X, float Y, float centerX, float centerY, float scale, PosmosVV.Proc.Galaxy galaxy)
        {
            res = new List<float>();
            inds = new List<int>();
            float Xorig = (X - centerX) / scale;
            float Yorig = (Y - centerY) / scale;
            int integ = 0;

            float maxOffset = 50f;

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
                //MessageBox.Show($"we chose {winner}");
                Form2 display = new Form2();
                display.temp = (int)galaxy.systems[winnerwinner].Primary_bodies[0].temperature;
                display.size = galaxy.systems[winnerwinner].Primary_bodies[0].size;
                display.bodies = galaxy.systems[winnerwinner].Primary_bodies.Count;
                display.inder = winnerwinner;
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
