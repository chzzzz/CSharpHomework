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
using Homework10;
namespace OrderWinF
{
    public partial class Form1 : Form
    {
        public OrderService service;
        public Form1()
        {
            
            OrderService service = new OrderService();
            this.service = service;
            InitializeComponent();
            
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            bindingSource1.DataSource = service.GetAllOrders();

            

          

        }
        

        private void dataGridView2_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void addOrder_Click(object sender, EventArgs e)
        {
            
            Form2 form2 = new Form2();
            form2.service = this.service;
            if(form2.ShowDialog()!=null)
            {
                bindingSource1.DataSource = service.GetAllOrders();
                bindingSource1.ResetBindings(true);
            }

            
        }

        private void dataGridView1_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
       
        }

        private void bindingSource1_CurrentChanged_1(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource = service.GetAllOrders();
            bindingSource1.ResetBindings(true);
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }

        private void deleteByName_Click(object sender, EventArgs e)
        {
            service.DeleteByName(textBox1.Text);
            bindingSource1.DataSource = service.GetAllOrders();
        }

        private void deleteById_Click(object sender, EventArgs e)
        {

            service.Delete(int.Parse(textBox2.Text));
            bindingSource1.DataSource = service.GetAllOrders();

        }
        private void InquiryByName_Click(object sender, EventArgs e)
        {
            bindingSource1.DataSource= service.InquiryByName(textBox3.Text);
        }

        private void InquiryById_Click(object sender, EventArgs e)
        {
            try
            {
                Order order = service.Inquiry(int.Parse(textBox4.Text));
                bindingSource1.DataSource = order;
                
            }
            catch
            {

            }
        }

        private void button2_Click(object sender, EventArgs e)
        {
            
        }

        private void groupBox2_Enter(object sender, EventArgs e)
        {

        }

        private void button2_Click_1(object sender, EventArgs e)
        {
            try
            {
                var a = dataGridView1.SelectedCells[2].Value.ToString();
                Form3 form3 = new Form3(service.Inquiry(int.Parse(a)));
                if (form3.ShowDialog() != null)
                {
                    bindingSource1.DataSource = service.GetAllOrders();
                    bindingSource1.ResetBindings(true);
                }
            }
            catch(Exception x)
            {
                MessageBox.Show("请选定一个Order"+x.Message);
            }
        }
    }
}
