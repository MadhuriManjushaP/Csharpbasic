using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class RangeNumbers
    {
        static void Main(string[] args)
        {
            int x, y;
            Console.WriteLine("enter 2 numbers");
            x = Int32.Parse(Console.ReadLine());
            y = Int32.Parse(Console.ReadLine());

            for(int i = x; i < y; i++)
            {
                if (i % 2 == 0)
                {
                    Console.WriteLine(i);
                }
            }


        }
    }
}
