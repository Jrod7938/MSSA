using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D1C1 {
    internal class Program {
        static void Main(string[] args) {
            SavingsAccount savingsAccount = new SavingsAccount(300.0f);

            savingsAccount.AccountNumber = 219313;
            savingsAccount.HolderName = "Billy B. Bob";

            Console.WriteLine($"Savings MinBalance {savingsAccount.MinBalance}");
            Console.WriteLine($"Enter Balance for account number: {savingsAccount.AccountNumber}");
            double balance = double.Parse(Console.ReadLine());
            if (balance > savingsAccount.MinBalance) {
                savingsAccount.Balance = balance;
            }
            Console.WriteLine($"Savings Balance {savingsAccount.Balance}");


            CheckingAccount checkingAccount = new CheckingAccount(200);
            Console.WriteLine($"Checking MinBalance {checkingAccount.MinBalance}");

        }
    }
}
