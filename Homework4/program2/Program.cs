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
            service.AddOrder("obc", 2);
            service.AddOrder("csd", 1);
        }
    }
}
