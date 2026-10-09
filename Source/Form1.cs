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

        private void panel1_Paint(object sender, PaintEventArgs e)
        {
            Graphics g = e.Graphics;
            g.Clear(Color.Black);
            PosmosVV.Proc.Galaxy ciao = new Proc.Galaxy();

            float galaxySize = 15000f;
            ciao.GenerateGalaxy(123, (int)galaxySize, 0.155f);
            float centerX = panel1.ClientSize.Width / 2f;
            float centerY = panel1.ClientSize.Height / 2f;


            float scale = Math.Min(panel1.ClientSize.Width, panel1.ClientSize.Height) * 0.5f / galaxySize;
            Thread.Sleep(1000);
            foreach (var s in ciao.systems)
            {
                float x = centerX + s.coordinates[0] * scale;
                float y = centerY + s.coordinates[1] * scale;

                float starSize = Math.Max(1f, 2f * scale);

                g.FillEllipse(Brushes.White, x - starSize / 2, y - starSize / 2, starSize, starSize);
            }
        }
    }
}
