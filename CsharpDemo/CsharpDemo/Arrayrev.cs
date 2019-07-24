using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Arrayrev
    {
        static void Main(string[] args)
        {
            int[] a=new int[10]; //Array declaration 

            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine("Enter number");
                a[i]= Int32.Parse(Console.ReadLine()); //read nums using for loop

            }
            Array.Sort(a);
            //Array.Reverse(a);
            foreach(int j in a.Reverse())  //reverse() used to print foreach array in reverse order
            {
                Console.WriteLine(j);
            }
        }
    }
}
