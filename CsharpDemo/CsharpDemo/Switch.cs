using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Switch
    {
        static void Main(string[] args)
        {
            int a;
            Console.Write("enter number");
            a= Int32.Parse(Console.ReadLine());
            switch(a){
                case 1:
                    Console.WriteLine("case 1");
                    break;
                case 2:
                    Console.WriteLine("case 2");
                    break;
                case 3:
                    Console.WriteLine("case 3");
                    break;
                default:
                    Console.WriteLine("none of the above");
                    break;


            }


        }
    }
}
