using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class PassbyValue
    {
        static void Main(string[] args)
        {
            int n = 100;
            Value(n);
            Console.WriteLine(n);
            int g = 200;
            Reference(ref g);
            Console.WriteLine(g);



        }
        //Pass by value
        static void Value(int n)
        {
            n = 0;
        }

        //Pass by reference
        static void Reference(ref int g)
        {
            g= 0;
        }

    }
}
