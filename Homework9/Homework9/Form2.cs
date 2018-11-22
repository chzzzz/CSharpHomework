using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using project1;
using System.Text.RegularExpressions;
namespace OrderWinF
{
    
    public partial class Form2 : Form
    {
        int count=0;
        public OrderService service;
        public Form2()
        {
            
            InitializeComponent();
          


        }
        private void Form2_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = service;
            label2.DataBindings.Add("Text",bindingSource1, "OrderNu");
            
        }

        private void textBox1_TextChanged(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void creat_b_Click(object sender, EventArgs e)
        {

            Order order=new Order(1,"3",23);
            bool t = true;
            try
            {
                order = new Order(int.Parse(textBox2.Text), textBox1.Text, service.OrderNu);
                if (order.JudgeSerialNu(textBox3.Text) != true)
                {
                    throw new Exception();
                }
                if (Regex.IsMatch(textBox4.Text, "^[0-9]{11}$"))
                {
                    order.TellNu = textBox4.Text;
                }
                else
                {
                    throw new Exception();
                }
            } catch
            {
                MessageBox.Show("请输入有效数据");
                t = false;
            }
            if (t)
            {
                if (int.Parse(textBox2.Text) != 0)
                {
                    button1.Enabled = true;
                }
                else
                {
                    button2.Enabled = true;
                }
                creat_b.Enabled = false;
                textBox2.Enabled = false;
                textBox1.Enabled = false;
                label5.Text = "未完成订单数量";
                bindingSource2.DataSource = order.orderDetails;
                dataGridView1.DataSource = bindingSource2;
                label2.DataBindings.Clear();
                label2.DataBindings.Add("Text", bindingSource1, "OrderNu");
                service.orders.Add(order);
            }
        }

        private void listView1_SelectedIndexChanged(object sender, EventArgs e)
        {
             
        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            try
            {
                OrderDetails details = new OrderDetails(detailName.Text, int.Parse(detailNu.Text), int.Parse(detailPrice.Text));
                int count = int.Parse(textBox2.Text);
                count--;
                service.orders[service.OrderNu - 2].orderDetails[this.count] = details;
                this.count++;
                if (count == 0)
                {
                    button1.Enabled = false;
                    this.count = 0;
                    button2.Enabled = true;
                }
                textBox2.Text = count.ToString();
                dataGridView1.DataSource = null;
                dataGridView1.DataSource = bindingSource2;
            }catch
            {

            }
        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            creat_b.Enabled = true;
            button2.Enabled = false;
            textBox1.Enabled=true;
            textBox2.Enabled = true;
        }
    }
}
