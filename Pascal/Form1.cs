namespace Pascal
{
    public partial class Form1 : Form
    {
        int m = 40;
        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            for (int sor = 0; sor < 10; sor++)
            {
                for (int oszlop = 0; oszlop < sor + 1; oszlop++)
                {
                    
                    Button b = new Button();
                    b.Width = m;
                    b.Height = m;
                    b.Left = oszlop * m;
                    b.Top = sor * m;
                    Controls.Add(b);
                    int x = Factorial(sor) / (Factorial(oszlop) * Factorial(sor - oszlop));
                    b.Text = x.ToString();


                }
            }
        }

        int Factorial(int n)
        {
            if (n == 0) return 1;
            return n * Factorial(n - 1);
        }


    }
}