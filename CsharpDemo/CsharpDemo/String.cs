using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class String
    {
        static void Main(string[] args)
        {
            string name;
            Console.Write("My favorite language is:");
            name = Console.ReadLine();
            if (name == "English")
            {
                Console.WriteLine("So you are English!");
            }
            else
            {
                Console.WriteLine("I am Hindi speaking");
            }
        }
    }
}
