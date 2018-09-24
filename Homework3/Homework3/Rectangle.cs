using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Rectangle:Graph
    {
        public Rectangle()
        {
            System.Console.WriteLine("创建长方形");
        }
        public override void OutPutArea()
        {
            try
            {
                System.Console.WriteLine("请输入边长1");
                Length1 = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("请输入边长2");
                Length2 = double.Parse(System.Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("请输入正确数值");
            }
            System.Console.WriteLine($"边长{length[0]},{length[1]} 面积{length[0] * length[1]}");
        }
    }
}
