using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D1C2 {
    internal abstract class Person {
        private string firstName;

        // auto properties will create their own backing fields
        public string FirstName { 
            get { return this.firstName.ToUpper(); } // get helps use change how we return data
            set {
                if(value.Length <= 50) { // validation
                    this.firstName = value;
                } else {                 // Trim end
                    this.firstName = value.Substring(0, 50);
                }
            }

        }
        public string LastName { get; set; } // auto
        public int Age { get; set; }
        public string Address { get; set; }
        public void Communicate() {
            Console.WriteLine("I use a language to communicate.");
        }

        // virtual allows the change of functionality in derived classes
        // polymorphism
        public virtual void DoWork() {
            Console.WriteLine("I do some work.");
        }

        // abstract methods only belong to abstract classes
        // must be implemented in derived classes by overriding
        public abstract void FollowSchedule();
    }
}
