using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Banking
{
    class Account
    {
        private int acno;
        private string ahname;
        private double balance;

        //methods

        public void Open(int ano,string name)
        {
            acno = ano;
            ahname = name;
            balance = 0;

        }

        public void Deposit(double amount)
        {   if (amount > 0)
                balance += amount;
            else
                Console.WriteLine("Invalid Amount");
        }

        public void Withdraw(double amount)
        {
            if (amount < balance)
                balance -= amount;
            else
                Console.WriteLine("Insufficient funds");
        }
        //can i use 1 function to print 3 different return types?
        public double Getbalance()
        {   
            return balance;
        }

        public string Accountname()
        {
            return ahname;
        }

        public int Accountno()
        {
            return acno;
        }

        
    }
}
