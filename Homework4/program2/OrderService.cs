using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class OrderService
    {
        int finalOrder =0;
        List<Order> orders = new List<Order>();
        public void AddOrder(string orderName,int orderDetailNu)
        {
            Order order = new Order(orderDetailNu, orderName,finalOrder+1);
            try
            {
                Console.WriteLine("创建订单开始" + " " + "名称：" + orderName + " " + "订单号：" + finalOrder + 1);
                for (int i = 0; i < orderDetailNu; i++)
                {
                    Console.WriteLine("输入商品名称");
                    string name = Console.ReadLine();
                    Console.WriteLine("输入商品数量");
                    int nu = int.Parse(Console.ReadLine());
                    Console.WriteLine("输入单价");
                    int price = int.Parse(Console.ReadLine());
                    order.orderDetails[i] = new OrderDetails(name, nu, price);
                }
                orders.Add(order);
                finalOrder += 1;
            }catch
            {
                Console.WriteLine("数字输入有误");
            }
        }
        public Order InauiryOrder(int OrderID)
        {
            foreach (Order order in orders)
            {
                if (OrderID == order.orderNu)
                {
                    return order;
                }
            }
            return null;
        }
        public Order InquiryOrder(string orderName)
        {
            foreach (Order order in orders)
            {
                if (orderName == order.name)
                {
                    return order;
                }
            }
         
                return null;
            
        }

        public void ModifyOrder(int orderID)
        {
            OrderDetails orderDetails = null;
            try
            {
                Order order = InauiryOrder(orderID);
                if(order==null)
                {
                    throw new MyException("找不出此条目");
                }
                orders.Remove(order);
                Console.WriteLine("请输入新的名字");
                string orderName = Console.ReadLine();
                Console.WriteLine("输入要修改的条目名称");
                string detailName = Console.ReadLine();
                for(int i =0;i<order.orderNu;i++)
                {
                    if(detailName==order.orderDetails[i].Name)
                    {
                        orderDetails = order.orderDetails[i];
                    }
                }
                Console.WriteLine("输入要改的数量");
                try
                {
                    orderDetails.Nu = int.Parse(Console.ReadLine());
                }catch(MyException e)
                {
                    throw new MyException("输入数字有误", e);
                }
            }catch(MyException e)
            {
                if(e.InnerException!=null)
                {

                    Console.WriteLine("内部原有  " + e.Message);
                }
                Console.WriteLine(e.Message );
            }
            
        }
        public void DeleteOrder(int orderID)
        {
            try
            {
                Order order = InauiryOrder(orderID);
                if(order==null)
                {
                    throw new MyException("找不出此条目");
                }
                orders.Remove(InauiryOrder(orderID));
            }catch(MyException e)
            {
                Console.WriteLine(e.Message);
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
