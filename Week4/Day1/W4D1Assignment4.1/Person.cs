using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D1Assignment4._1 {
    internal class Person {
        public string ?FirstName { get; set; }
        public string ?LastName { get; set; }
        public long MobilePhone { get; set; }
        public long WorkPhone { get; set; }
        public string Address { get; set; }

        public Person(string firstName, string lastName, long mobilePhone, long workPhone, string address) {
            FirstName = firstName;
            LastName = lastName;
            MobilePhone = mobilePhone;
            WorkPhone = workPhone;
            Address = address;
            PhoneBook.People.Add($"{firstName} {lastName}", this);
        }
    }
}
