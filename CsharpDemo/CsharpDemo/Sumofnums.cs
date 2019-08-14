using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Sumofnums
    {
        static void Main(string[] args)
        {
            int num;
            Console.WriteLine("enter number");
            num = Int32.Parse(Console.ReadLine());
            int sum = 0;
            for (int i = 1; i <= num; i++)
            {
                sum += i;

            }
            

            Console.WriteLine("sum of numbers is :"+sum);
            for (int j = 1; j <=num; j++)
            {
                Console.WriteLine("Squares of numbers is:{0}", Math.Pow(j, 2));
            }
        }

        
    }
}
