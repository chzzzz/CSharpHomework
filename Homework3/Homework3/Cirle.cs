using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Cirle:Graph
    {
        const double pi = 3.14;
        public Cirle()
        {
            System.Console.WriteLine("创建圆形");
        }
        public override void OutPutArea()
        {
            try
            {
                System.Console.WriteLine("请输入半径");
                Length1 = double.Parse(System.Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("请输入正确数值");
            }
            System.Console.WriteLine($"半径为{length[0]} 圆面积为{length[0] * length[0] * pi}");
        }
    }
}
