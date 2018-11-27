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
using System.Data.Entity;
namespace Homework10
{
    public partial class Form3 : Form
    {
        Order order;
        public Form3()
        {
            InitializeComponent();
        }
        public Form3(Order order)
        {
            this.order = order;
            
            InitializeComponent();
            bindingSource1.DataSource = order;
            textBox1.DataBindings.Add("Text", bindingSource1, "Name");
            textBox2.DataBindings.Add("Text", bindingSource1, "TellNu");
        }
        private void Form3_Load(object sender, EventArgs e)
        {

        }

        private void button1_Click(object sender, EventArgs e)
        {
            using (OrderDB dB = new OrderDB())
            {
                dB.Order.Attach(order);
                dB.Entry(order).State = EntityState.Modified;
                order.OrderDetails.ForEach(
                    OrderDetail => dB.Entry(OrderDetail).State = EntityState.Modified);
                dB.SaveChanges();
            }
        }

        private void bindingSource1_CurrentChanged(object sender, EventArgs e)
        {

        }
    }
}
