using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W10D1Assignment10._1 {
    public class Customer {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public double Price { get; set; }

        public Customer(string FirstName, string LastName, string Address, double Price) {
            this.FirstName = FirstName;
            this.LastName = LastName;
            this.Address = Address;
            this.Price = Price;
        }

        public Customer() { }
    }
}
