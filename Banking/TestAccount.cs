using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class TestAccount
    {
        static void Main(string[] args)
        {
            Account a = new Account();
            a.Open(1,"Madhuri");
            a.Deposit(1000);
            a.Withdraw(200);
            double balance=a.Getbalance();
            string name = a.Accountname();
            int num = a.Accountno();
            Console.WriteLine("Account Details :");
        Console.WriteLine ("Name:{0}" +Environment.NewLine+ "Number:{1}"+Environment.NewLine+
            "Balance:{2}",
                name , num , balance);  
           // Console.WriteLine("NewLine: {0}  first line{0}  second line{0}  third line", Environment.NewLine);

        }
    }
}
