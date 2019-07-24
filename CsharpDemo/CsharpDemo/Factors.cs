using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Factors
    {
        static void Main(string[] args)
        {
            int num, i;
            Console.Write("Enter a number");
            num = Int32.Parse(Console.ReadLine());
            for (i = 2; i < num; i++)
            {
                if (num % i == 0)
                {
                    Console.WriteLine(i);
                }
            }
        }
    }
}
