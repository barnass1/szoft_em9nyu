namespace KigyosJatek
{
    public partial class Form1 : Form
    {
        int fej_x = 100;
        int fej_y = 100;
        int ir�ny_x = 1;
        int ir�ny_y = 0;
        int lepesszam;
        int hossz = 5;
        List<KigyoElem> k�gy� = new List<KigyoElem>();
        public Form1()
        {
            InitializeComponent();

        }

        private void Form1_Load(object sender, EventArgs e)
        {
            KeyDown += Form1_KeyDown;
        }

        private void Form1_KeyDown(object? sender, KeyEventArgs e)
        {


            if (e.KeyCode == Keys.Up)
            {
                ir�ny_y = -1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Down)
            {
                ir�ny_y = 1;
                ir�ny_x = 0;
            }

            if (e.KeyCode == Keys.Left)
            {
                ir�ny_y = 0;
                ir�ny_x = -1;
            }

            if (e.KeyCode == Keys.Right)
            {
                ir�ny_y = 0;
                ir�ny_x = 1;
            }


        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            lepesszam++;
            fej_x += ir�ny_x * KigyoElem.Meret;
            fej_y += ir�ny_y * KigyoElem.Meret;

            foreach (KigyoElem item in Controls)
            {
                if (item.Top == fej_y && item.Left == fej_x)
                {
                    timer1.Enabled = false;
                    return;
                }
            }



            KigyoElem ke = new KigyoElem();
            if (lepesszam % 2 == 0)
                ke.BackColor = Color.Pink;
            ke.Top = fej_y;
            ke.Left = fej_x;
            Controls.Add(ke);

            if (Controls.Count > hossz) Controls.RemoveAt(0);
            if (hossz % 5 == 0) hossz++;

        }
    }
}