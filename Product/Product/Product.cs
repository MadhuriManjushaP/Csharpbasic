using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Product
{
    class Product
    {
        private string name;
        private int price, quantity;

        public Product(string n,int p,int q=0)
        {
            name = n;
            price = p;
            quantity = q;
            Print();
        }

        public void Purchase(int quant)
        {
            quantity -= quant;
        }

        public void Sell(int quant)
        {
            quantity += quant;
        }
        public void Print()
        {
            Console.WriteLine("quantity {0}",quantity);
        }

    }
}
