namespace Fibonacci
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

            List<sor> lista = new List<sor>();

            for (int i = 0; i < 10; i++)
            { 

                sor �jSor = new();
                �jSor.�rt�k = Fibonacci(i);
                �jSor.Sorszam = i;
                lista.Add(�jSor);
            }

            dataGridView1.DataSource = lista;

        }

        int Fibonacci(int n)
        {
            if (n == 0) return 0;
            if (n == 1) return 1;
            return Fibonacci(n - 1) + Fibonacci(n - 2);
        }
    }
}