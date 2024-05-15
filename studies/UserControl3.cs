using studies.Models;
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
    public partial class UserControl3 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl3()
        {
            InitializeComponent();

            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void FillDataSource()
        {
            var ilist = from i in context.Instructors
                        where i.Name.Contains(textBox1.Text)
                        select i;
            listBox1.DataSource = ilist.ToList();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            Instructor instructor = (Instructor)listBox1.SelectedItem;

            if (listBox1.SelectedItem == null) return;
            Instructor selectedInstructor = listBox1.SelectedItem as Instructor;
            

            var employement = from l in context.Instructors
                              where l.InstructorSk == selectedInstructor.InstructorSk

                              select new
                          {
                              Munkahely = l.Name,
                              Beosztás = l.StatusFkNavigation.Name
                          };


            dataGridView1.DataSource = employement.ToList();
        }

        private void UserControl3_Load(object sender, EventArgs e)
        {

        }
    }
}
