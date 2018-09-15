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
                try
                {
                    Console.WriteLine("输入一个正整数：");
                    int n =int.Parse( Console.ReadLine());
                    Console.Write("它的素质数为：");
                    for(int i=2;i<=n;i++)
                    {
                        bool isPrime=true;
                        for(int j=2;j<i;j++)
                        {
                            if(i%j==0)
                            {
                                isPrime = false;
                                break;
                            }
                        }
                        if(isPrime&&n%i==0)
                        {
                            Console.Write($"{i} ");
                            n /= i;
                            i = 1;
                        }

                    }
                    Console.WriteLine();
                    Console.WriteLine("继续输入任意数字，不继续输入0");
                    a = int.Parse(Console.ReadLine());

                }
                catch (Exception e1)
                {
                    Console.WriteLine("请输入符合要求的数" + e1.Message);
                    continue;
                }
            }
        }
    }
}
