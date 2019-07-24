using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class Arrayorder
    {
        static void Main(string[] args)
        {
            int[] marks = new int[5];

            
            //read marks
            
            for(int i = 0; i < marks.Length; i++)
            {            Console.WriteLine("Enter Marks");

                marks[i] = Int32.Parse(Console.ReadLine());
            }
            Array.Sort(marks);
            //print marks ascending order
            Console.WriteLine("Marks Entered in ascending order are:");
            foreach(int v in marks)
                {
                
                Console.WriteLine(v);
                           }
                           
            //print marks descending order
            Console.WriteLine("Marks Entered in descending order are:");

            for(int i = marks.Length - 1; i >= 0; i--)
            {
                Console.WriteLine(marks[i]);
            }
        }
    }
}
