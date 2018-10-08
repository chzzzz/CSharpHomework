using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace clock
{
    public class ClockEventArgs : EventArgs
    {
        public string Infomation { get; set; }
        public DateTime Time{ get; set; }
    }
    public delegate void ClockEventHandler(object sender, ClockEventArgs e);
    public class Clock
    {
        public event ClockEventHandler ShowInformation;
        public void SetClock()
        {
            DateTime setTime;
            string information;
            try
            {
                System.Console.WriteLine("设置闹钟时间");
                System.Console.WriteLine("输入年份");
                int year = int.Parse(Console.ReadLine());
                System.Console.WriteLine("输入月份");
                int mouth = int.Parse(Console.ReadLine());
                System.Console.WriteLine("输入日期");
                int day = int.Parse(Console.ReadLine());
                System.Console.WriteLine("输入几点");
                int hour = int.Parse(Console.ReadLine());
                System.Console.WriteLine("输入几分");
                int minute = int.Parse(Console.ReadLine());
                setTime = new DateTime(year, mouth, day, hour, minute, 0);
                System.Console.WriteLine("输入提醒信息");
                information = Console.ReadLine();
            }catch
            {
                information = "请输入正确的数据";
                setTime = DateTime.Now;
            }
            while (true)
            {
                if (setTime.Year==DateTime.Now.Year&&
                    setTime.Month == DateTime.Now.Month &&
                    setTime.Day == DateTime.Now.Day &&
                    setTime.Hour == DateTime.Now.Hour &&
                    setTime.Minute == DateTime.Now.Minute 
                    )
                {
                    ClockEventArgs args = new ClockEventArgs();
                    args.Time = setTime;
                    args.Infomation = information;
                    ShowInformation(this, args);
                    break;
                }

            }
        }
    }
   
}
