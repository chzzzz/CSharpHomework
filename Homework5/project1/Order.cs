using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace project1
{
    class Order
    {
        public Order(int orderDetailNu,string name,int orderNu)
        {
            orderDetails = new OrderDetails[orderDetailNu];
            this.name = name;
            this.orderNu = orderNu;
        }
        public string name;
        public int orderNu;

        public OrderDetails[] orderDetails;

    }
}
