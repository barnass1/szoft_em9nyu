namespace VillogoGomb
{
    public partial class Form1 : Form
    {

        int M�ret = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    VillogoGomb b = new VillogoGomb();
                    b.Height = M�ret;
                    b.Width = M�ret;
                    b.Left = oszlop * M�ret;
                    b.Top = sor * M�ret;
                    b.Text = ((sor + 1) * (oszlop + 1)).ToString();
                    Controls.Add(b);
                }
            }
        }
    }
}