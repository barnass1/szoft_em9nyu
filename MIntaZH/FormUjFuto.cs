using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MIntaZH
{
    public partial class FormUjFuto : Form
    {
        public futo UjFuto = new();
        public FormUjFuto()
        {
            InitializeComponent();
        }

        private void FormUjFuto_Load(object sender, EventArgs e)
        {
            futoBindingSource.DataSource = UjFuto;
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }
    }
}
