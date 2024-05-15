using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace studies
{
    public partial class Form2 : Form
    {
        studies.Models.StudiesContext context = new studies.Models.StudiesContext();
        public Form2()
        {
            InitializeComponent();
        }

        public object Course { get; internal set; }

        private void Form2_Load(object sender, EventArgs e)
        {

        }
    }
}
