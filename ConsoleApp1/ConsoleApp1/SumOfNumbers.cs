using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class SumOfNumbers
    {
        static void Main(string[] args)
        {
            
            Console.Write("Enter a number");
            int num = Int32.Parse(Console.ReadLine());
            int sum=0;
            for(int i = 1; i <= num; i++)
            {
                
                 sum += i;
            }
            Console.WriteLine("Sum of numbers is {0}", sum);
        }
    }
}
