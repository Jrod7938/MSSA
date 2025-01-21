using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D1C1 {
    abstract class BankAccount {
        public int AccountNumber { get; set; }
        public string HolderName { get; set; }
        public double Balance { get; set; }
        protected double minBalance;
        public double MinBalance { get { return this.minBalance; } }
       

    }
}
