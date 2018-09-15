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
            int b = 1;
            while (b != 0)
            {
                int[] a;
                const int number = 10;
                a = new int[number];
                Random random = new Random();
                int max = 0;
                int min = 50;
                int sum = 0;
                for (int i = 0; i < number; i++)
                {
                    a[i] = random.Next(50);
                    Console.Write($"{a[i]}    ");
                    sum += a[i];
                    if (a[i] > max)
                        max = a[i];
                    if (a[i] < min)
                        min = a[i];
                }
                Console.WriteLine();
                double avg = sum / (double)number;
                Console.Write($"总和为：{sum}\t最大值为：{max}\t最小值为；{min}\t平均数为；{avg}");
                try
                {
                    Console.WriteLine();
                    Console.WriteLine("继续输入任意数字，不继续输入0");
                    b = int.Parse(Console.ReadLine());
                }catch()
                {
                }
            }
        }
    }
}
