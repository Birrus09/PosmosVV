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
        public int gtrackerbar;

        public int[] coordis = new int[2];
        public float[] unscaled = new float[2];
        private PosmosVV.Proc.Galaxy gal;
        public List<int[]> kords;
        int[] coords;
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
            coords = new int[2];
            Rectangle rect = new Rectangle((panel1.ClientSize.Width - rectSize) / 2, (panel1.ClientSize.Height - rectSize) / 2, rectSize, rectSize);

            kords = new List<int[]>();

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
                if (body.distance > 0)
                {
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

                    int X = panel1.ClientSize.Width / 2 + OffX - rounded / 2;
                    int Y = panel1.ClientSize.Height / 2 + OffY - rounded / 2;
                    coords[0] = X;
                    coords[1] = Y;
                    Rectangle rect2 = new Rectangle(X, Y, rounded, rounded);
                    SolidBrush brush = new SolidBrush(Color.FromArgb(body.RGBINT()));
                    e.Graphics.FillEllipse(brush, rect2);

                    kords.Add(coords);
                }
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
            CordsT.Visible = true;
            UnscT.Visible = true;
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
            CordsT.Text = $"Coordinates (X/Y): {coordis[0]}; {coordis[1]}";
            UnscT.Text = $"Unscaled Coords (X/Y): {unscaled[0]}; {unscaled[1]}";
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
        }

        private void Form2_Click(object sender, MouseEventArgs e)
        {
            PosmosVV.GUI.GUI_util utility = new GUI.GUI_util();
            int x = e.X;
            int y = e.Y;
            float centerX = panel1.ClientSize.Width / 2f;
            float centerY = panel1.ClientSize.Height / 2f;
            int galaxySize = gtrackerbar;
            float scale = Math.Min(panel1.ClientSize.Width, panel1.ClientSize.Height) * 0.5f / galaxySize;
            //compare
        }
    }
}
// aumenta il coefficeiente della distanza (x2/x3)
// fixa la size della window principale
// aggiungi orbite
// ad aumentare di galaxy size aumenta il range del click
