namespace HajosKviz
{
    public partial class Form1 : Form
    {
        List<Kerdes> ÖsszesKerdes;
        List<Kerdes> AktualisKerdesek;
        int AktualisKerdes = 5;

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ÖsszesKerdes = KerdesBetoltes();
            AktualisKerdesek = new List<Kerdes>();
            for (int i = 0; i < 7; i++)
            {
                AktualisKerdesek.Add(ÖsszesKerdes[0]);
                ÖsszesKerdes.RemoveAt(0);
            }
            dataGridView1.DataSource = AktualisKerdesek;

            Kerdesmegjelenites(AktualisKerdesek[AktualisKerdes]);
        }

        void Kerdesmegjelenites(Kerdes kérdés)
        {
            label1.Text = kérdés.KérdésSzöveg;
            valaszGomb1.Text = kérdés.Válasz1;
            valaszGomb2.Text = kérdés.Válasz2;
            valaszGomb3.Text = kérdés.Válasz3;

            if (string.IsNullOrEmpty(kérdés.URL))
            {
                pictureBox1.Visible = false;
            }
            else
            {
                pictureBox1.Load("https://storage.altinum.hu/hajo/" + kérdés.URL);
                pictureBox1.Visible = true;
            }

        }

        List<Kerdes> KerdesBetoltes()
        {
            List<Kerdes> kerdesek = new List<Kerdes>();

            try
            {

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }

            StreamReader sr = new StreamReader("hajozasi_szabalyzat_kerdessor_BOM.txt", true);
            while (!sr.EndOfStream)
            {
                string sor = sr.ReadLine() ?? "";
                string[] tömb = sor.Split("\t");
                if (tömb.Length != 7) continue;
                Kerdes k = new Kerdes();
                k.KérdésSzöveg = tömb[1];
                k.Válasz1 = tömb[2];
                k.Válasz2 = tömb[3];
                k.Válasz3 = tömb[4];
                k.URL = tömb[5];

                int x = 0;
                int.TryParse(tömb[6], out x);
                k.HelyesVálasz = x;

                kerdesek.Add(k);

            }
            sr.Close();

            return kerdesek;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (AktualisKerdes == 6)
            {
                AktualisKerdes = 0;
            }
            else 
            {
                AktualisKerdes++;
            }
            
            Kerdesmegjelenites(AktualisKerdesek[AktualisKerdes]);
        }
    }
}