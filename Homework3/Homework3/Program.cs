using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Homework3
{
    class Program
    {
        static void Main(string[] args)
        {
            int a = 1;
            Graph graph = null;
            while(a!=0)
            {
                System.Console.WriteLine("输入想创建的图形（Cirle,Rectangle,Square,Triangle）");
                string name;
                name = System.Console.ReadLine();
                graph = GraphFactory.CreatGraph(name);
                if(graph!=null)
                {
                    graph.OutPutArea();
                }else
                {
                    System.Console.WriteLine("请输入正确的图形名字");
                }
                try
                {
                    System.Console.WriteLine("退出输入0，继续输入其他整数");
                    a = int.Parse(System.Console.ReadLine());
                }
                catch
                {
                }

            }
        }
    }
}
