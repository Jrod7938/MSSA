using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2C1 {
    // static classes can only hold static methods
    internal static class OutputFormatter { // static class cannot be derived or instantiated
        public static void DisplayName(string firstName) {
            Console.WriteLine($"Welcome {firstName}, enjoy the course.");
        }

        public static void DisplayName(string firstName, string lastName) {
            Console.WriteLine($"Welcome {firstName} {lastName}, welcome to the course.");
        }
    }
}
