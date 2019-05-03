using System;
using System.Drawing;
using System.Windows.Forms;




namespace Math_Graphic
{

    public partial class Graphic : Form
    {


        public Graphic()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void Label1_Click(object sender, EventArgs e)
        {

        }

        private void Label2_Click(object sender, EventArgs e)
        {

        }

        private void PictureBox1_Click(object sender, EventArgs e)
        {

        }

        private void TextBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void Button1_Click(object sender, EventArgs e)
        {
            Graphics g = pictureBox1.CreateGraphics();
            float cx = pictureBox1.Width;
            float cy = pictureBox1.Height;

            PointF[] ptf = new PointF[Convert.ToInt32(cx)];

            
            int R = Convert.ToInt32(textBox1.Text);

            double t = Math.PI / 180;

            g.Clear(pictureBox1.BackColor);

           for (int i = 0; i <cx; i++)
            {
                ptf[i].X = (cx / 2) + (float)(Math.Cos(i*t) * 2 * R * (1 - Math.Cos(i*t)));
                ptf[i].Y = (cy / 2) + (float)(Math.Sin(i*t) * 2 * R * (1 - Math.Cos(i*t)));
                
            }
            
            g.DrawLines(Pens.Blue,ptf);
            g.DrawLine(Pens.Black, 0, (cy/ 2), cx, (cy / 2));
            g.DrawLine(Pens.Black, (cx / 2), 0, (cx/2), cy);
            
        }

    }
}