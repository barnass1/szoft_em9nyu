using csillagterkep.Models;

namespace csillagterkep
{
    public partial class Form1 : Form
    {

        public Form1()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void buttonRajz_Click(object sender, EventArgs e)
        {
            Graphics g = this.CreateGraphics();

            Pen pen = new Pen(Color.White);
            Brush brush = new SolidBrush(Color.White);


            HajosContext context = new HajosContext();
            var stars = (from x in context.StarData
                         select new { x.Hip, x.X, x.Y, x.Magnitude }).ToList();

            double nagyitas = 300;
            int cx = ClientRectangle.Width / 2;
            int cy = ClientRectangle.Height / 2;

            g.Clear(Color.DarkBlue);

            foreach (var star in stars)
            {
                if (star.Magnitude > 6)
                {
                    continue;
                }
                if (Math.Sqrt(Math.Pow(star.X, 2) + Math.Pow(star.Y, 2)) > 1)
                {
                    continue;
                }

                float x = (float)(star.X * nagyitas + cx);
                float y = (float)(star.Y * nagyitas + cy);
                double size = 20 * Math.Pow(10, star.Magnitude / -2.5);

                g.FillEllipse(brush, x, y, (float)size, (float)size);

            }

            var lines = context.ConstellationLines.ToList();
            foreach (var line in lines)
            {
                var star1 = stars.FirstOrDefault(x => x.Hip == line.Star1);
                var star2 = stars.FirstOrDefault(x => x.Hip == line.Star2);

                if (star1 == null || star2 == null)
                {
                    continue;
                }

                if (star1.Magnitude > 6 || star2.Magnitude > 6)
                {
                    continue;
                }

                if (Math.Sqrt(Math.Pow(star1.X, 2) + Math.Pow(star1.Y, 2)) > 1 ||
                                       Math.Sqrt(Math.Pow(star2.X, 2) + Math.Pow(star2.Y, 2)) > 1)
                {
                    continue;
                }

                float x1 = (float)(star1.X * nagyitas + cx);
                float y1 = (float)(star1.Y * nagyitas + cy);
                float x2 = (float)(star2.X * nagyitas + cx);
                float y2 = (float)(star2.Y * nagyitas + cy);

                g.DrawLine(pen, x1, y1, x2, y2);
            }
        }
    }
}