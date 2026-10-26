using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosmosVV
{
    partial class Form2 : Form
    {
        public int temp;
        public int size;
        public int bodies;
        public int inder;
        private PosmosVV.Proc.Galaxy gal;
        public Form2()
        {
            InitializeComponent();
            //panel1.Invalidate();
            waitTime();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            int b = -35;
            int rectSize = (size / 2) + b;
            Rectangle rect = new Rectangle((panel1.ClientSize.Width - rectSize) / 2, (panel1.ClientSize.Height - rectSize) / 2, rectSize, rectSize);

            using (GraphicsPath path = new GraphicsPath())
            {
                path.AddEllipse(rect);

                using (PathGradientBrush brush = new PathGradientBrush(path))
                {
                    if (temp >= 12000)
                    {
                        brush.CenterColor = Color.FromArgb(255, 0, 211, 255);
                    }
                    else if (temp >= 9500)
                    {
                        brush.CenterColor = Color.FromArgb(255, 172, 255, 243);
                    }
                    else if (temp >= 7500)
                    {
                        brush.CenterColor = Color.FromArgb(255, 255, 255, 255);
                    }
                    else if (temp >= 6000)
                    {
                        brush.CenterColor = Color.FromArgb(255, 254, 255, 211);
                    }
                    else if (temp >= 5200)
                    {
                        brush.CenterColor = Color.FromArgb(255, 252, 255, 54);
                    }
                    else if (temp >= 3700)
                    {
                        brush.CenterColor = Color.FromArgb(255, 255, 215, 54);
                    }
                    else if (temp >= 1)
                    {
                        brush.CenterColor = Color.FromArgb(255, 255, 131, 54);
                    }

                    brush.SurroundColors = new Color[]
                    {
                        Color.FromArgb(0, 0, 150, 255)
                    };

                    e.Graphics.FillEllipse(brush, rect);
                }
            }
            for (int i = 1; i < gal.systems[inder].Primary_bodies.Count; i++)
            {
                var body = gal.systems[inder].Primary_bodies[i];
                int rounded = Math.Max(1, (int)(body.size / 25f));

                int distance = body.distance / 4;
                int son = (int)(body.size / 2) + 40;

                int OffX = Random.Shared.Next(-distance, distance + 1);
                int OffY = Random.Shared.Next(-distance, distance + 1);

                //non renderizzare dentro la stella
                double linglong = Math.Sqrt((double)OffX * OffX + (double)OffY * OffY);

                if (linglong > 0)
                {
                    OffX += (int)(OffX / linglong * son);
                    OffY += (int)(OffY / linglong * son);
                }

                Rectangle rect2 = new Rectangle(panel1.ClientSize.Width / 2 + OffX - rounded / 2, panel1.ClientSize.Height / 2 + OffY - rounded / 2, rounded, rounded);

                e.Graphics.FillEllipse(Brushes.White, rect2);
            }

        }

        private async void waitTime()
        {
            await Task.Delay(250);
            pictureBox1.Visible = false;
            pictureBox2.Visible = true;
            await Task.Delay(100);
            pictureBox2.Visible = false;
            panel1.Visible = true;
            starSpect.Visible = true;
            trademark.Visible = true;
            set();
            tempT.Visible = true;
            sizeT.Visible = true;
            bodiesT.Visible = true;
            panel1.Invalidate();
        }
        public void set()
        {
            string unit = "M";
            int div = 100;
            int bods = bodies - 1;
            if (size < 180)
            {
                unit = "K";
                div = 1;
            }
            tempT.Text = $"Temperature: {temp} C°";
            sizeT.Text = $"Radius: {size / div}{unit} Km";
            bodiesT.Text = $"Orbiting bodies: {bods}";
        }

        private void tempT_Click(object sender, EventArgs e)
        {

        }

        private void trademark_Click(object sender, EventArgs e)
        {

        }

        public void superserious_function(PosmosVV.Proc.Galaxy galacsi)
        {
            gal = galacsi;
            string fuck = "number | size | distance\n";

            for (int i = 1; i < galacsi.systems[inder].Primary_bodies.Count; i++)
            {
                fuck += $"{i} | " + galacsi.systems[inder].Primary_bodies[i].size + " | " + galacsi.systems[inder].Primary_bodies[i].distance;
                fuck += "\n";
            }
            
            MessageBox.Show($"{fuck}");
        }
    }
}
