using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D1C2 {
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine("Variables and Data Types");

            // Data Types Variable Name
            int i; // 32 bit signed number
            char c = 'n'; // Initialized variable, 16 bit Unicode character
            float f = 3.14f; // 32 bit floating point number
            double d = 3.14; // 64 bit floating point number
            bool b = true; // Boolean value
            string s = "Hello"; // String

            Console.WriteLine("Enter your name: ");
            string name = Console.ReadLine();

            Console.WriteLine($"{name}, where do you live?");
            string address = Console.ReadLine();
            Console.WriteLine($"Nice, you live in {address}");

            Console.WriteLine("Enter your age: ");
            float age = Convert.ToSingle(Console.ReadLine());
            Console.WriteLine($"{name}, you are {age} years old and live in {address}.");

            int num1,
                num2;
            
            Console.WriteLine("Enter two numbers. Press enter after each number.");
            num1 = Convert.ToInt32(Console.ReadLine());
            num2 = Convert.ToInt32(Console.ReadLine());

            int result = num1 + num2;

            Console.WriteLine($"The sum of {num1} and {num2} is {result}.");
        }
    }
}
