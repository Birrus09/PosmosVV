using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PosmosVV.Game
{
    public partial class Form1 : Form
    {
        private readonly PosmosVV.Proc.Domain domain;

        public Form1()
        {
            InitializeComponent();

            var galaxy = new PosmosVV.Proc.Galaxy();
            galaxy.GenerateGalaxy2(6589, size: 3000);

            var bodies = galaxy.systems
                .SelectMany(system => system.Primary_bodies.Skip(1))
                .ToList();
            var randomBody = bodies[Random.Shared.Next(bodies.Count)];

            domain = new PosmosVV.Proc.Domain();
            randomBody.DOM = domain;
            domain.DOMINIT(20);

            pictureBox1.Paint += PictureBox1_Paint;
        }

        private void PictureBox1_Paint(object? sender, PaintEventArgs e)
        {
            e.Graphics.Clear(Color.Black);
            e.Graphics.SmoothingMode = System.Drawing.Drawing2D.SmoothingMode.AntiAlias;

            const float margin = 16f;
            const float rootThree = 1.7320508f;
            int rowCount = domain.HEXMAP.Count;
            int columnCount = domain.HEXMAP.Max(row => row.Count);
            float radius = Math.Min(
                (pictureBox1.ClientSize.Width - margin * 2) / (rootThree * (columnCount + 0.5f)),
                (pictureBox1.ClientSize.Height - margin * 2) / (1.5f * (rowCount - 1) + 2f));

            if (radius <= 0f)
            {
                return;
            }

            float hexWidth = rootThree * radius;
            float mapWidth = hexWidth * (columnCount + 0.5f);
            float mapHeight = radius * (1.5f * (rowCount - 1) + 2f);
            float originX = (pictureBox1.ClientSize.Width - mapWidth) / 2f;
            float originY = (pictureBox1.ClientSize.Height - mapHeight) / 2f;

            using var pen = new Pen(Color.White, 1.25f);
            foreach (var row in domain.HEXMAP.Select((hexes, index) => (hexes, index)))
            {
                for (int column = 0; column < row.hexes.Count; column++)
                {
                    float centerX = originX + hexWidth * (column + 0.5f + row.index % 2 * 0.5f);
                    float centerY = originY + radius * (1f + row.index * 1.5f);
                    var points = Enumerable.Range(0, 6)
                        .Select(vertex =>
                        {
                            double angle = Math.PI / 180d * (30d + vertex * 60d);
                            return new PointF(
                                centerX + radius * (float)Math.Cos(angle),
                                centerY + radius * (float)Math.Sin(angle));
                        })
                        .ToArray();

                    e.Graphics.DrawPolygon(pen, points);
                }
            }
        }
    }
}
