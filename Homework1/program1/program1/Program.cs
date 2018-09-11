using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            while (a != 0)
            {
                Console.WriteLine("请输入第一个数：");
                string N1 = Console.ReadLine();
                Console.WriteLine("请输入第二个数：");
                string N2 = Console.ReadLine();
                int n1 = Convert.ToInt32(N1);
                int n2 = Convert.ToInt32(N2);
                Console.WriteLine("他们的乘积为：");
                Console.WriteLine("{0}",n1*n2);
                Console.WriteLine("输入0退出，继续任意按键");
                string j= Console.ReadLine();
                a = Convert.ToInt32(j);
            }
        }
    }
}
