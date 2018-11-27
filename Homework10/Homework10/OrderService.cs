using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Serialization;
using System.Runtime.Serialization;
using System.IO;
using System.Xml;
using System.Xml.XPath;
using System.Xml.Xsl;
using Homework10;
namespace project1
{
    public class OrderService
    {

        public int Final
        {
            get
            {
                int final = 0;
                foreach (Order order in GetAllOrders())
                {
                    if (order.OrderNu > final)
                    {
                        final = order.OrderNu;
                    }
                }
                return final;
            }
        }

        //public List<Order> orders = new List<Order>();

        public int OrderNu
        {
            get
            {
                return Final + 1;
            }
        }
        public void AddOrder( Order order)
        {
            using (var db = new OrderDB())
            {
                db.Order.Add(order);
                db.SaveChanges();
            }
        }
        public void Delete(int orderId)
        {
            using (var db = new OrderDB())
            {
                var order = db.Order.Include("OrderDetails").SingleOrDefault(o => o.OrderNu == orderId);
                db.OrderDetail.RemoveRange(order.OrderDetails);
                db.Order.Remove(order);
                db.SaveChanges();
            }
        }
        public Order Inquiry(int Id)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("OrderDetails").
                  SingleOrDefault(o => o.OrderNu == Id);
            }
        }
        public List<Order> InquiryByName(string name)
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("OrderDetails").TakeWhile(o => o.Name == name).ToList();
                    
            }
        }
        public void DeleteByName(string name)
        {
            using (var db = new OrderDB())
            {
                var orders= db.Order.Include("OrderDetails").TakeWhile(o => o.Name == name);
                foreach(Order order in orders)
                {
                    db.OrderDetail.RemoveRange(order.OrderDetails);
                }
                db.Order.RemoveRange(orders);
                db.SaveChanges();

            }
        }
        
        public List<Order> GetAllOrders()
        {
            using (var db = new OrderDB())
            {
                return db.Order.Include("OrderDetails").ToList<Order>();
            }
        }
    }
    class MyException : ApplicationException
    {
        public MyException(string message):base(message)
        {

        }
        public MyException(string message,Exception inner):base(message,inner)
        {

        }
    }
}
