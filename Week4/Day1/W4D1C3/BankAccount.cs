using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D1C3 {

    delegate void LowBalance(double bal);
    internal class BankAccount {
        public event LowBalance LowBalance;
        public int AccountNumber { get; set; }

        private double accountBalance;
        public double AccountBalance {  
            get { return this.accountBalance; } 
            set {
                if (value < 200) LowBalance(value); // raising of event
                else {
                    this.accountBalance = value;
                }
            }
        }

    }
}
