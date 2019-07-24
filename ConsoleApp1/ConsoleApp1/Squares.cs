using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Squares
    {
        static void Main(string[] args)
        {
            Console.Write("Enter a number");
            int num = Int32.Parse(Console.ReadLine());

            for(int i = 1; i <= num; i++)
            {
                Console.WriteLine(Math.Pow(i, 2) );
            }
        }
    }
}
