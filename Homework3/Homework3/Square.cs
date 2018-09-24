using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Square:Graph
    {
        public Square()
        {
            System.Console.WriteLine("创建正方形");
        }
        public override void OutPutArea()
        {
            try
            {
                System.Console.WriteLine("请输入边长");
                Length1 = double.Parse(System.Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("请输入正确数值");
            }
            System.Console.WriteLine($"边长{length[0]} 面积{length[0] * length[0]}");
        }
    }
}
