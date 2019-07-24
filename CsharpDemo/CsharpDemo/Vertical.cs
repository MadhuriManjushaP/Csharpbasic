using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Vertical
    {
        static void Main(string[] args)
        {
            string name;
            Console.WriteLine("enter a string");
            name = Console.ReadLine();
            
            Console.WriteLine(name.ToUpper());
            string[] words = name.Split(' ');
            foreach(string w in words)
            {
                Console.WriteLine(w);
            }
            char[] a = name.ToCharArray();
            foreach(char c in a)
            {
                Console.WriteLine(c);
            }
         
        }
    }
}
