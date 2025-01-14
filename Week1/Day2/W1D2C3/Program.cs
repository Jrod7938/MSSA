using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D2C3 {
    internal class Program {
        // For Loop Demo
        static void Main(string[] args) {

            Console.WriteLine("First 10 numbers");

            // for(initilization, evaluate, increment)
            for (int i = 1; i <= 10; i++) {
                Console.WriteLine(i);
            }

            // Even numbers
            Console.WriteLine("EVEN");
            for (int i = 1; i <= 50; i++) {
                if (i % 2 == 0) {
                    Console.WriteLine(i);
                }
            }

            Console.WriteLine("REVERSE");
            for (int i = 10; i >= 1; i--) {
                Console.WriteLine(i);
            }


            Console.WriteLine("FACTORIAL");
            // 5! = 5 * 4 * 3 * 2 * 1
            int factorial = 1;
            for(int i = 1; i <= 5; i++) {
                factorial = factorial * i;
                Console.WriteLine(factorial);
            }


            int j = 1;
            while (j <= 20) {
                Console.WriteLine(j);
                j++;
            }
        }
    }
}
