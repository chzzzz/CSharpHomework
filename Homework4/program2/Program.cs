using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program2
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            service.AddOrder("asd", 4);
            service.AddOrder("asds", 1);
            service.DeleteOrder(2);
            service.ModifyOrder(2);
        }
    }
}
