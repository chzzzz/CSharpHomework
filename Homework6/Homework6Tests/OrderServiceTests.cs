using Microsoft.VisualStudio.TestTools.UnitTesting;
using project1;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1.Tests
{
    [TestClass()]
    public class OrderServiceTests
    {

        [TestMethod()]
        public void InauiryOrderTest()
        {
            OrderService service = new OrderService();
            Order c = new Order(1, "asdsad", 1);
            service.orders.Add(c);
            Order a = service.InauiryOrder(2);
            Order b = service.InauiryOrder(1);
            Assert.IsNull(a);
            Assert.AreSame(c, b);
            
        }

        [TestMethod()]
        public void InquiryOrderTest()
        {
            OrderService service = new OrderService();
            Order c = new Order(1, "asdsad", 1);
            service.orders.Add(c);
            Order a = service.InquiryOrder("asdsa");
            Order b = service.InquiryOrder("asdsad");
            Assert.IsNull(a);
            Assert.AreSame(c, b);
        }

        [TestMethod()]
        public void InquiryByLinqTest()
        {
            OrderService service = new OrderService();
            service.orders.Add(new Order(1, "asdsad", 1));
            List<Order> a = service.InquiryByLinq("asdsa");
            List<Order> b = service.InquiryByLinq("asdsad");
            Assert.AreEqual(a.Count, 0);
            Assert.AreEqual("asdsad", b[0].name);
        }

        [TestMethod()]
        public void InquiryMoneyByLinqTest()
        {
            OrderService service = new OrderService();
            Order order = new Order(1, "bob", 1);
            OrderDetails details = new OrderDetails("abc", 100, 1500);
            order.orderDetails[0] = details;
            service.orders.Add(order);
            List<Order> a = service.InquiryMoneyByLinq(150000);
            List<Order> b = service.InquiryMoneyByLinq(200000);
            Assert.AreEqual(b.Count, 0);
            Assert.AreEqual("bob", a[0].name);

        }
        [TestMethod()]
        public void DeleteOrderTest()
        {
            OrderService service = new OrderService();
            Order order = new Order(1, "bob", 1);
            OrderDetails details = new OrderDetails("abc", 100, 1500);
            order.orderDetails[0] = details;
            service.orders.Add(order);
            service.DeleteOrder(1);
            service.DeleteOrder(0);
            Assert.AreEqual(0, service.orders.Count);
        }

        [TestMethod()]
        public void ExportTest()
        {
            OrderService service = new OrderService();
            Order order = new Order(1, "bob", 1);
            OrderDetails details = new OrderDetails("abc", 100, 1500);
            order.orderDetails[0] = details;
            service.orders.Add(order);
            Assert.AreEqual(true, service.Export("x.xml"));
        }

        [TestMethod()]
        public void ImportTest()
        {
            OrderService service = new OrderService();
            Assert.AreEqual(true, service.Import("x.xml"));
            Assert.AreEqual(false, service.Import("s.xml"));
        }
    }
}