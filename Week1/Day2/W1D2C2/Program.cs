using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D2C2 {
    internal class Program {
        // If Else Demo
        static void Main(string[] args) {
            Console.WriteLine("Speed Checker");
            Console.WriteLine("Enter speed: ");
            int speed = int.Parse(Console.ReadLine());

            CheckSpeed(speed);

        }

        static void CheckSpeed(int speed) {
            if (speed > 55) {
                if (speed > 55 && speed <= 65) {
                    Console.WriteLine("Within limits");
                } else if (speed > 85) {
                    Console.WriteLine("Reckless driving, license revoked!");
                } else {
                    Console.WriteLine("You are speeding");
                }
            } else {
                Console.WriteLine("Within limits");
            }
        }
    }
}
