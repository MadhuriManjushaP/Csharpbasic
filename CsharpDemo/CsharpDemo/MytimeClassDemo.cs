using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class MytimeClassDemo
    {
        private int hour, min, sec;
        public void Set(int h,int m,int s)
        {
            hour = h;
            min = m;
            sec = s;

        }
        public void Print()
        {
            Console.WriteLine($"{hour}:{min}:{sec}");
        }
    }
}
