namespace PosmosVV
{
    public partial class Form1 : Form
    {
        private PosmosVV.Proc.Galaxy ciao;
        public Form1()
        {
            InitializeComponent();
            panel1.Invalidate();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void startButton_Click(object sender, EventArgs e)
        {
            startButton.Visible = false;
            galaxySizeTrackBar.Visible = false;
            galaxySizeValueLabel.Visible = false;
            scatterTrackBar.Visible = false;
            scatterValueLabel.Visible = false;
            panel1.Visible = true;
            panel1.Invalidate();
        }

        private void scatterTrackBar_ValueChanged(object sender, EventArgs e)
        {
            float scatter = scatterTrackBar.Value / 100000f;
            scatterValueLabel.Text = $"Scatter: {scatter:F5}";
            if (panel1.Visible)
            {
                panel1.Invalidate();
            }
        }

        private void galaxySizeTrackBar_ValueChanged(object sender, EventArgs e)
        {
            galaxySizeValueLabel.Text = $"Galaxy size: {galaxySizeTrackBar.Value}";
            if (panel1.Visible)
            {
                panel1.Invalidate();
            }
        }

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            PosmosVV.Proc.Galaxy ciao = new Proc.Galaxy();

            int galaxySize = galaxySizeTrackBar.Value;
            ciao.GenerateGalaxy(123, galaxySize, scatterTrackBar.Value / 100000f);
            float centerX = panel1.ClientSize.Width / 2f;
            float centerY = panel1.ClientSize.Height / 2f;


            float scale = Math.Min(panel1.ClientSize.Width, panel1.ClientSize.Height) * 0.5f / galaxySize;
            foreach (var s in ciao.systems)
            {
                float x = centerX + s.coordinates[0] * scale;
                float y = centerY + s.coordinates[1] * scale;

                float starSize = Math.Max(1f, 2f * scale);

                if (s.Primary_bodies[0].size > 350)
                {
                    g.FillEllipse(Brushes.White, x - starSize / 2, y - starSize / 2, 2 * starSize, 2 * starSize);
                }
                else
                {
                    g.FillEllipse(Brushes.White, x - starSize / 2, y - starSize / 2, starSize, starSize);
                }

            }
        }
    }
}
