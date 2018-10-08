using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using clock;
namespace program1
{
    class Program
    {
        static void Main(string[] args)
        {
            Clock clock = new Clock();
            clock.ShowInformation += Show;
            clock.SetClock();
            Console.ReadLine();
        }
        static void Show(object sender, ClockEventArgs e)
        {
            Console.WriteLine(e.Time.ToString() +"  "+ e.Infomation);
        }
    }
}
