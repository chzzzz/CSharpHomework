using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Collections;
namespace program3
{
    class Program
    {
        static void Main(string[] args)
        {
            ArrayList arrayList = new ArrayList();
            const int max = 120;
            for(int i = 2; i <= max; i++)
            {
                arrayList.Add(i);
            }
            for(int i=2;i<=max/2;i++)
            {
                for(int j =i+1;j<=arrayList.Count;j++)
                {
                    if ((int)arrayList[j - 1] % i == 0)
                    {
                        arrayList.RemoveAt(j - 1);
                        j -= j - 1;
                    }

                }
            }
            Console.WriteLine($"{max}以内素数：");
            for(int i=0;i<arrayList.Count;i++)
            {
                Console.WriteLine($"{arrayList[i]}");
            }
            Console.WriteLine("输入任意键退出");
            Console.ReadLine();
        }
    }
}
