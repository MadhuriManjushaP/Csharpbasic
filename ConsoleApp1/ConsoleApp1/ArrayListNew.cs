using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ConsoleApp1
{
    class ArrayListNew
    {
        static void Main(string[] args)
        {
            ArrayList My_array = new ArrayList(); // Create an ArrayList using ArrayList class

            //Adding array elements to ArrayList
            My_array.Add(10);
            My_array.Add("Hello World");
            My_array.Add(null);
            My_array.Add(12);

            //display the elements

            foreach (var elements in My_array)
            {
                Console.WriteLine(elements);
            }

            //displaying count of arraylist elements

            Console.WriteLine("Number of elements: {0}" , My_array.Count);

            //displaying capacity of arraylist elements

            Console.WriteLine("capacity is: {0}" ,My_array.Capacity);
        }
    }
}
