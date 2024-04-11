using CsvHelper;
using System.ComponentModel;
using System.Globalization;

namespace european_countries
{
    public partial class Form1 : Form
    {
        BindingList<CountryData> countryList = new BindingList<CountryData>();
        public Form1()
        {
            InitializeComponent();
            countryDataBindingSource.DataSource = countryList;
            dataGridView1.DataSource = countryDataBindingSource;
        }

        private void button1_Click(object sender, EventArgs e)
        {

            Form2 form2 = new Form2();
            form2.CountryData = countryDataBindingSource.Current as CountryData;
            form2.Show();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void torles_Click(object sender, EventArgs e)
        {
            countryDataBindingSource.RemoveCurrent();
        }

        private void megnyit_Click(object sender, EventArgs e)
        {
            StreamReader sr = new StreamReader("european_countries.csv");
            var csv = new CsvReader(sr, CultureInfo.InvariantCulture);
            var tömb = csv.GetRecords<CountryData>();
            foreach (var item in tömb)
            {
                countryList.Add(item);
            }
        }

        private void mentes_Click(object sender, EventArgs e)
        {
            using (var writer = new StreamWriter("european_countries.csv"))
            using (var csv = new CsvWriter(writer, CultureInfo.InvariantCulture))
            {
                csv.WriteRecords(countryList);
            }
        }
    }
}