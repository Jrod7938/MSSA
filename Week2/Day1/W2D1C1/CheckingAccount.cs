using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D1C1 {
    internal class CheckingAccount : BankAccount {
        public CheckingAccount(double minBalance) {
            this.minBalance = minBalance;
        }
    }
}
