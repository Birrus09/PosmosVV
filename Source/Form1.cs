namespace PosmosVV
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
            PosmosVV.Proc.Galaxy ciao = new Proc.Galaxy();
            ciao.GenerateGalaxy(123);
        }
    }
}
