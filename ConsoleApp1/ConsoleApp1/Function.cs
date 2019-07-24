using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class Function
    {
        static void Main(string[] args)
        {
            int sum = Add(10, 20); //Actual Parameters
            Console.WriteLine("Sum = {0}", sum);

        }
        static int Add (int n1,int n2) //Formal Parameters
        {
            return n1 + n2;
        }
    }
}
