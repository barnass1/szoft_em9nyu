namespace VillogoGomb
{
    public partial class Form1 : Form
    {

        int Méret = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            List<hatvany> lista = new List<hatvany>();

            for (int i = 0; i < 101; i++)
            {

                hatvany újSor = new();
                újSor.Érték = (int)Math.Pow(i, 2);
                újSor.Sorszam = i;
                lista.Add(újSor);
            }

            dataGridView1.DataSource = lista;

            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < 10; oszlop++)
                {
                    SzamoloGomb b = new SzamoloGomb();
                    b.Height = Méret;
                    b.Width = Méret;
                    b.Left = oszlop * Méret;
                    b.Top = sor * Méret;
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