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
            List<hatvany> lista = new List<hatvany>();

            for (int i = 0; i < 101; i++)
            {

                hatvany �jSor = new();
                �jSor.�rt�k = (int)Math.Pow(i, 2);
                �jSor.Sorszam = i;
                lista.Add(�jSor);
            }

            dataGridView1.DataSource = lista;

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzamoloGomb b = new SzamoloGomb();
                    b.Height = M�ret;
                    b.Width = M�ret;
                    b.Left = oszlop * M�ret;
                    b.Top = sor * M�ret;
                    //b.Text = ((sor + 1) * (oszlop + 1)).ToString();
                    Controls.Add(b);
                }
            }
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }
    }
}