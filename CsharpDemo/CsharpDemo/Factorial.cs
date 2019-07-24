using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Factorial
    {
        static void Main(string[] args)
        {
            int fact = 1;
            Console.Write("Enter a number");
            int num = Int32.Parse(Console.ReadLine());
            for (int i =1; i<=num; i++)
            {
               fact = fact * i;
            }
            Console.WriteLine("Factorial of {0} is {1}",num,fact);
        }
    }
}
