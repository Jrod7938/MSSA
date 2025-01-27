using System;
using System.Text.RegularExpressions;

namespace W3D1C3 {
    internal class Program {
        static void Main(string[] args) {
        input:
            Console.WriteLine("Enter your name");
            string name = Console.ReadLine();

            if (ContainsDigits(name)) {
                Console.WriteLine("Entered only digits, please enter a name");
                goto input;
            } else {
            email:
                Console.WriteLine($"{name}, please enter your email id");
                string email = Console.ReadLine();
                if (CheckEmail(email)) {
                    Console.WriteLine($"{name}, you are registered");
                } else {
                    Console.WriteLine("Invalid Email");
                    goto email;
                }
            }
        }

        static bool ContainsDigits(string name) {
            return Regex.IsMatch(name, "\\d");
        }

        static bool CheckEmail(string email) {
            string emailPatter = @"^[^@\s]+@[^@\s]+\.[^@\s]+$";
            return Regex.IsMatch(email, emailPatter);
        }
    }
}
