using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CsharpDemo
{
    class FunOverload
    {
        static int Add(int a, int b) => a + b;
        static int Multiply(int a=1, int b=20) => a * b; 
        static void SetToZero(out int n) => n = 0;  //formal parameter
        //params keyword copies all 
        //array actual parameters into nums
        static int Total(params int[] nums) {
            int sum = 0;
            foreach (int n in nums)
                sum += n;
            return sum;
        }
        static void Main(string[] args)
        {
            int sum = Add(10, 20);
            Console.WriteLine("sum:{0}",sum);
            int v;             //no need to initialise v when using out keyword
            SetToZero(out v);  //actual parameter
            Console.WriteLine("Multiplication of 10 and 20 :{0}", Multiply(10, 20));
            Console.WriteLine("Multiplication of 5 and 2:{0}",Multiply(a:5,b:2));
            Console.WriteLine("Multiply 10:{0}",Multiply(10));
            Console.WriteLine("Multiply :{0}", Multiply());
            Console.WriteLine("Total sum of 1,2,3,4,5 :{0}",Total(1,2,3,4,5));

        }
            

    }
}
