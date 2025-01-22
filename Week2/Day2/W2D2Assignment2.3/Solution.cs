using System;
using System.IO;

namespace W2D2Assignment2._3 {
    internal class Solution {
        public static void Part1() {
            const string PATH = "UserDetails.txt";

            Console.WriteLine("Enter your name:");
            string name = Console.ReadLine();

            Console.WriteLine("Enter your age:");
            string age = Console.ReadLine();

            Console.WriteLine("Enter your address:");
            string address = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(PATH)) {
                writer.WriteLine(name);
                writer.WriteLine(age);
                writer.WriteLine(address);
                writer.WriteLine(DateTime.Now);
            }
            Console.WriteLine("Data written to file.");

            using (StreamReader reader = new StreamReader(PATH)) {
                Console.WriteLine("Reading data from file:");
                Console.WriteLine(reader.ReadToEnd());
            }
        }

        public static void Part2() {
            Console.Write("Enter the tip rate (0.18 for 18%): ");
            if (!double.TryParse(Console.ReadLine(), out double tipRate) || tipRate < 0 || tipRate > 1) {
                Console.WriteLine("Invalid tip rate. Please enter a value between 0 and 1.");
                return;
            }

            Console.Write("Enter the bill total: ");
            if (!double.TryParse(Console.ReadLine(), out double billTotal) || billTotal < 0) {
                Console.WriteLine("Invalid bill total. Please enter a positive value.");
                return;
            }

            double tip = billTotal * tipRate;

            Console.WriteLine();
            Console.WriteLine("".PadRight(25, '*'));
            Console.WriteLine($"Bill Total: \t{billTotal,8:c}");
            Console.WriteLine($"Tip: \t\t{tip,8:c}");
            Console.WriteLine($"Tip Rate: \t{tipRate,8:p}");

            Console.WriteLine("".PadRight(25, '-'));
            Console.WriteLine($"Total: \t\t{billTotal + tip,8:c}");
            Console.WriteLine("".PadRight(25, '*'));
        }
    }
}