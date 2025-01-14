using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D2C1 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("What is your name?");
            string name = Console.ReadLine();
            DisplayGreeting(name);

            Console.WriteLine("Enter 2 numbers to add:");
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int sum = AddNumbers(number1, number2); 
            Console.WriteLine("The sum of the numbers is: " + sum);
        }

        // Static Methods do not require an instance of the class to be called
        static void DisplayGreeting(string name) {
            Console.WriteLine($"Hello {name}, nice to meet you."); // string interpolation
        }

        static int AddNumbers(int number1, int number2) {
            return number1 + number2;
        }
    }
}
