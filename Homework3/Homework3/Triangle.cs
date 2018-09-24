using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Triangle:Graph
    {
        public Triangle()
        {
            System.Console.WriteLine("创建三角形");
        }

        public override void OutPutArea()
        {
            try
            {
                System.Console.WriteLine("请输入边长1");
                Length1 =double.Parse (System.Console.ReadLine());
                System.Console.WriteLine("请输入边长2");
                Length2 = double.Parse(System.Console.ReadLine());
                System.Console.WriteLine("请输入边长3");
                Length3 = double.Parse(System.Console.ReadLine());
            }
            catch
            {
                System.Console.WriteLine("请输入正确数值");
            }
            if((length[0]+length[1])<=length[2]|| (length[0] - length[1]) >= length[2])
            {
                System.Console.WriteLine("请输入正确边长");
            }
            else
            {
                double p = (length[0] + length[1] + length[2]) / 2;
                System.Console.WriteLine($"边长{length[0]},{length[1]},{length[2]} 三角形面积为{p * (p - length[0]) * (p - length[1]) * (p - length[2])}");
            }
        }
    }
}
