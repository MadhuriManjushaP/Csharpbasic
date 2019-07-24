using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class Coursenew
    {
        private string title;
        private int duration;
        private int price;

        public void Create(string ctitle,int cduration, int cprice)
        {
            title = ctitle;
            duration = cduration;
            price = cprice;
            Console.WriteLine("Course Duration Fee");
            Console.WriteLine("{0},{1},{2}", title, duration, price);
        }
        
        /*public void Print()
        {
            Console.WriteLine("Course Duration Fee");
            Console.WriteLine("{0},{1},{2}",title, duration, price);
        }*/
        
        public double Getnetfee()
        {
            
            double netfee = price + (0.18 * price);
            return netfee;
        }
    }
}
