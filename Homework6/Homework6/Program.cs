using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using project1;

namespace Homework6
{
    class Program
    {
        static void Main(string[] args)
        {
            OrderService service = new OrderService();
            service.Import("x.xml");
            service.AddOrder("Bob", 3);
            service.AddOrder("Jim", 2);
            service.Export("s.xml");
        }
    }
}
