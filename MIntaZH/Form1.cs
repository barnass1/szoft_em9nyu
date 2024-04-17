using CsvHelper;
using System.ComponentModel;
using System.Globalization;
namespace MIntaZH
{
    public partial class Form1 : Form
    {

        BindingList<futo> futo = new BindingList<futo>();
        public Form1()
        {
            InitializeComponent();
            //dataGridView1.DataSource = futo;
            futoBindingSource.DataSource = futo;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonBetolt_Click(object sender, EventArgs e)
        {
            try
            {
                StreamReader sr = new StreamReader("futoversenyzok.txt");
                var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
                var t = csv.GetRecords<futo>();
                foreach (var item in t)
                {
                    futo.Add(item);
                }

            }
            catch (Exception ex)
            {

                MessageBox.Show(ex.Message);
            }
        }

        private void buttonMentes_Click(object sender, EventArgs e)
        {
            SaveFileDialog sfd = new SaveFileDialog();
            if (sfd.ShowDialog() == DialogResult.OK)
            {
                try
                {
                    StreamWriter streamWriter = new StreamWriter(sfd.FileName);
                    var csv = new CsvWriter(streamWriter, CultureInfo.InvariantCulture);
                    csv.WriteRecords(futo);

                    streamWriter.Close();
                }
                catch (Exception ex)
                {

                    MessageBox.Show(ex.Message); ;
                }
            }
        }

        private void buttonTorles_Click(object sender, EventArgs e)
        {
            if (futoBindingSource.Current == null) return;

            if (MessageBox.Show("Biztosan törölni szeretné?", "Törlés", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
            {
                futoBindingSource.RemoveAt(futoBindingSource.Position);
            }
        }

        private void buttonUj_Click(object sender, EventArgs e)
        {
            FormUjFuto formUjFuto = new FormUjFuto();
            if (formUjFuto.ShowDialog() == DialogResult.OK)
            {
                futo.Add(formUjFuto.UjFuto);
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            double minimum = double.PositiveInfinity;
            string leggyorsabb = string.Empty;

            foreach (var item in futo)
            {
                minimum = item.EredmenyPerc;
                leggyorsabb = item.Nev;
            }

            MessageBox.Show($"A leggyorsabb versenyző: {leggyorsabb}");
        }
    }
}
