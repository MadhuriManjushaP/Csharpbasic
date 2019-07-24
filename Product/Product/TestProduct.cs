using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class TestProduct
    {
        static void Main(string[] args)
        {
            Product p = new Product("vaseline",25,10);
            p.Purchase(2);
            p.Sell(5);
            p.Print();
        }

    }
}
