using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.DirectoryServices.ActiveDirectory;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosmosVV
{
    partial class Form3 : Form
    {
        public int distance;
        public int bodies;
        public int temperature;
        public int size;
        public decimal rotation;
        public decimal revolution;
        public string type;

        private PosmosVV.Proc.Galaxy gal;
        public int win;
        public int ei;

        public HatchBrush brushete = new HatchBrush(HatchStyle.ForwardDiagonal, Color.White, Color.Black);
        public Form3()
        {
            InitializeComponent();
            waitTime();
        }


        private async void waitTime()
        {
            await Task.Delay(350);
            set();
            planetSpect.Visible = true;
            trademark.Visible = true;
            tempT.Visible = true;
            sizeT.Visible = true;
            bodiesT.Visible = true;
            DistT.Visible = true;

            RotT.Visible = true;
            RevoT.Visible = true;
            TypeT.Visible = true;

            panel1.Visible = true;

            panel1.Invalidate();
        }
        public void superserious_function(PosmosVV.Proc.Galaxy galacsi)
        {
            gal = galacsi;
        }

        public void set()
        {
            tempT.Text = $"Temperature: {temperature} C°";
            sizeT.Text = $"Diameter: {size}K Km";
            bodiesT.Text = $"Moons: {bodies}";
            DistT.Text = $"Distance from star: {distance}M Km";
            RotT.Text = $"Rotation speed: {rotation}K Km/s";
            RevoT.Text = $"Revolution speed: {revolution} K Km/s";
            TypeT.Text = $"Planet type: {type}";
        }


        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            var body = gal.systems[ei].Primary_bodies[win];
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            int b = 15;
            int rectSize =(int)(((size / 2) + b) / 1.5);
            Rectangle rect = new Rectangle((panel1.ClientSize.Width - rectSize) / 2, (panel1.ClientSize.Height - rectSize) / 2, rectSize, rectSize);
            g.FillEllipse(brushete, rect);

            if (body.hasOrbitals)
            {
                for (int j = 0; j < body.Orbits.Count; j++)
                {
                    if (body.Orbits[j].distance != 0)
                    {
                        var orbit = body.Orbits[j];

                        int centrX = panel1.ClientSize.Width / 2;
                        int centrY = panel1.ClientSize.Height / 2;

                        int orbitR = (int)(orbit.distance * 2.5);

                        using (Pen orbitPen2 = new Pen(Color.FromArgb(100, Color.Gray), 1))
                        {
                            e.Graphics.DrawEllipse(orbitPen2, centrX - orbitR, centrY - orbitR, orbitR * 2, orbitR * 2);
                        }

                        double angleO = Random.Shared.NextDouble() * Math.PI * 2;

                        int OffXO = (int)(Math.Cos(angleO) * orbitR);
                        int OffYO = (int)(Math.Sin(angleO) * orbitR);

                        int moonX = centrX + OffXO;
                        int moonY = centrY + OffYO;

                        Rectangle rect3 = new Rectangle(moonX - 2, moonY - 2, 4, 4);

                        using (SolidBrush brush = new SolidBrush(Color.White))
                        {
                            e.Graphics.FillEllipse(brush, rect3);
                        }
                    }
                }
            }
        }
    }
}
