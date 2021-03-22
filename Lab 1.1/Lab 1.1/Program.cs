using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Lab_1._1
{
    class Program
    {
        static void Main(string[] args)
        {
            var a0 = new Account("Sajjad ", "41154", 10000);
            var a1 = new Account("Sajjad 1", "2", 20000);

            a0.Deposit(1000);
            a0.Withdraw(500);
            a0.Transfer(a1 ,4000);

            Console.WriteLine("Account Balance");

            a0.ShowInfo();
            a1.ShowInfo();

            Console.WriteLine("Account Transactions List");

            a0.ShowAllTransaction();
            a1.ShowAllTransaction();
        }
    }
}
