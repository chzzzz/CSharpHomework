using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace program2
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            if ((this.textBox1.Text != null)&& (this.textBox1.Text != null))
            {
                Int64 n1 = Convert.ToInt64(this.textBox1.Text);
                Int64 n2 = Convert.ToInt64(this.textBox2.Text);
                this.label4.Text = Convert.ToString(n1 * n2);
            }

        }
    }
}
