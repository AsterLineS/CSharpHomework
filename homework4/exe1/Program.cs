using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace exe1
{
    public class ClockEventArgs : EventArgs
    {
        public string SetTime
        {
            set;
            get;
        }
    }

    public delegate void ClockEventHandler(object sender, ClockEventArgs t);

    public class Clock
    {
        public event ClockEventHandler informing;
        public void IsTime()
        {
            ClockEventArgs setClock = new ClockEventArgs();
            setClock.SetTime = Console.ReadLine();
            while (true)
            {
                string currentTime = DateTime.Now.ToShortTimeString().ToString();

                if (currentTime == setClock.SetTime)
                {
                    informing(this, setClock);
                    break;
                }
            }
        }
    }
    class UseClock
    {
        static void Main()
        {
            Console.WriteLine("请输入闹钟时间：");
            var clock = new Clock();
            clock.informing += ClockInforming;
            clock.IsTime();
        }
        static void ClockInforming(object sender, ClockEventArgs t)
        {
            Console.WriteLine("时间到了！");
        }
    }
}
