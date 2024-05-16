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
    public partial class UserControl2 : UserControl
    {
        StudiesContext context = new StudiesContext();
        public UserControl2()
        {
            InitializeComponent();

            FillDataSource();
            listBox1.DisplayMember = "Name";
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {
            FillDataSource();
        }

        private void listBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (listBox1.SelectedItem == null) return;
            Course course = listBox1.SelectedItem as Course;

            dataGridView1.DataSource = (from l in context.Lessons
                                        where l.CourseFk == course.CourseSk
                                        select new
                                        {
                                            Nap = l.DayFkNavigation.Name,
                                            Sáv = l.TimeFkNavigation.Name,
                                            Oktató = l.InstructorFkNavigation.Name
                                        }).ToList();
        }

        private void FillDataSource()
        {
            listBox1.DataSource = (from c in context.Courses
                                   where c.Name.Contains(textBox1.Text)
                                   select c).ToList();
        }

        private void UserControl2_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            Form2 form2 = new Form2();
           if(form2.ShowDialog() == DialogResult.OK)
            {
                Lesson lesson = new Lesson();
                lesson.CourseFkNavigation = new Course(); // or get an existing Course object
                lesson.CourseFkNavigation.Name = form2.textBox1.Text;


                context.Lessons.Add(lesson);

                try
                {
                    context.SaveChanges();
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                    
                }


            }

        }
    }
}
