using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D1 { // Scope
    internal class Program { // Starting Point
        static void Main(string[] args) {
            Console.WriteLine("Hello World!");

            Console.WriteLine("What is your name?");
            string response = Console.ReadLine();

            Console.WriteLine($"Hello, {response}.");
        }
    }
}
