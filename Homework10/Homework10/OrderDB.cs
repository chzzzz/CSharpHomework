using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
using project1;
namespace Homework10
{
    class OrderDB : DbContext
    {
        public OrderDB():base("Model1")
        {

        }
        public DbSet<Order> Order { get; set; }
        public DbSet<OrderDetails> OrderDetail { get; set; }
    }
}
