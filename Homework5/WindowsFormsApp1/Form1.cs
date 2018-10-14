using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsFormsApp1
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

        private void button1_Click(object sender, EventArgs e)
        {

            if (RandomCheck.Checked)
            {
                Random random = new Random();
                Angel1.Value = (int)(random.Next(10, 110) / 10) * 10;
                Angel2.Value = (int)(random.Next(10, 110) / 10) * 10;
                Length1.Value = (int)(random.Next(10, 110) / 10) * 10;
                Length2.Value = (int)(random.Next(10, 110) / 10) * 10;
                Thickness.Value = (int)(random.Next(10, 60) / 10) * 20;
                Factor.Value = (int)(random.Next(10, 210) / 10) * 10;
                switch (random.Next(1, 4))
                {
                    case 1:
                        Blue.Checked = true;
                        break;
                    case 2:
                        Red.Checked = true;
                        break;
                    case 3:
                        Green.Checked = true;
                        break;
                }

            }
            if (graphics == null) graphics = this.CreateGraphics();
            graphics.Clear(Form1.DefaultBackColor);
            drawCayleyTree(10, 200, 310, 100, -Math.PI / 2);
        }
        private Graphics graphics;
       
        public int Angle1
        {
            get
            {
                return Convert.ToInt16(Angel1.Value);
            }
        }
        public int Angle2
        {
            get
            {
                return Convert.ToInt16(Angel2.Value);
            }
        }
        void drawCayleyTree(int n,
            double x0,double y0,double leng,double th)
        {
            
            double th1 = Angle1 * Math.PI / 180;
            double th2 = Angle2 * Math.PI / 180;
            double per1 = Convert.ToInt16(Length1.Value) / 100.0;
            double per2 = Convert.ToInt16(Length2.Value) / 100.0;
            double k = Convert.ToDouble(Factor.Value) / 100;
            if (n == 0) return;

            double x1 = x0 + leng * Math.Cos(th);
            double y1 = y0 + leng * Math.Sin(th);

            drawline(x0, y0, x1, y1);
            drawCayleyTree(n - 1, x1, y1, per1 * leng, th + th1);
            drawCayleyTree(n - 1, x1, y1, k*per2 * leng, th - th2);
        }
        void drawline(double x0,double y0,double x1,double y1)
        {
            string s;
            Pen pen =new Pen(Color.Blue);
            pen.Width = Convert.ToInt16(Thickness.Value)/20;
            if(Red.Checked)
            {
                s = Red.Text;
            }else if(Blue.Checked)
            {
                s = Blue.Text;
            }else
            {
                s = Green.Text;
            }
            switch (s)
            {
                case "蓝色\r\n":
                    pen.Color=Color.Blue;
                    break;
                case "红色\r\n":
                    pen.Color = Color.Red;
                    break;
                case "绿色\r\n":
                    pen.Color = Color.Green;
                    break;
            }
            graphics.DrawLine(
                pen, (int)x0, (int)y0, (int)x1, (int)y1);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown2_ValueChanged(object sender, EventArgs e)
        {

        }

        private void numericUpDown3_ValueChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void radioButton4_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void OffRandom_CheckedChanged(object sender, EventArgs e)
        {

        }
        double Abs(double x)
        {
            return x < 0 ? -x : x;
        }
        double Min(double x,double y)
        {
            return x < y ? x : y;
        }
    }
}
