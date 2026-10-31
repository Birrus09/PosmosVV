                    int rounded = Math.Max(1, (int)(body.size / 25f));

                    int distance = (body.distance / 4) - 25;
                    int son = (int)(body.size / 2) + 40;

                    int centX = panel1.ClientSize.Width / 2;
                    int centY = panel1.ClientSize.Height / 2;

                    int orbitRadius = distance + son;

                    using (Pen orbitPen = new Pen(Color.FromArgb(100, Color.Gray), 1))
                    {
                        e.Graphics.DrawEllipse(orbitPen, centX - orbitRadius, centY - orbitRadius, orbitRadius * 2, orbitRadius * 2);
                    }
