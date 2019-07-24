using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Course
{
    class TestCourse
    {
        static void Main(string[] args)
        {
            Coursenew c = new Coursenew();
            c.Create("Java",45,7000);
            c.Create("dotnet", 36, 8000);
           // c.Print();
            double netfee=c.Getnetfee();
            Console.WriteLine("netfee:{0}", netfee);
        }
    }
}
