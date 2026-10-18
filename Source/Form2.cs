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
    public partial class Form2 : Form
    {
        public int temp;
        public int size;
        public Form2()
        {
            InitializeComponent();
            //panel1.Invalidate();
            miBombo();
        }

        private void Form2_Load(object sender, EventArgs e)
        {

        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            Rectangle rect = new Rectangle((panel1.ClientSize.Width - 200) / 2, (panel1.ClientSize.Height - 200) / 2, size / 2 + 40, size / 2 + 40);

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
            /*Graphics g = e.Graphics;
            g.Clear(Color.DarkSalmon);
            int d = 100;
            g.FillEllipse(Brushes.White, 150, 150, d, d);
            e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;*/
        }

        private async void miBombo()
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
            panel1.Invalidate();
        }
        public void set()
        {
            tempT.Text = $"Temperature: {temp} C°";
            sizeT.Text = $"Size: {size}";
        }
    }
}
