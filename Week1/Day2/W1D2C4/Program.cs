using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D2C4 {
    internal class Program {
        // Switch Demo
        static void Main(string[] args) {

            string favColor;
            char choice = 'y';

            while(choice == 'y' || choice == 'Y') {
                Console.WriteLine("Choose a color (Yellow, Red, Blue, Green): ");
                favColor = Console.ReadLine();

                switch (favColor.ToLower()) {
                    case "yellow":
                        Console.ForegroundColor = ConsoleColor.Yellow;
                        Console.WriteLine("Yellow is a good choice.");
                        break;
                    case "red":
                        Console.ForegroundColor = ConsoleColor.Red;
                        Console.WriteLine("Red is a good choice.");
                        break;
                    case "blue":
                        Console.ForegroundColor = ConsoleColor.Blue;
                        Console.WriteLine("Blue is a good choice.");
                        break;
                    case "green":
                        Console.ForegroundColor = ConsoleColor.Green;
                        Console.WriteLine("Green is a good choice.");
                        break;
                    default:
                        Console.ForegroundColor = ConsoleColor.White;
                        Console.WriteLine("Invalid color choice.");
                        break;
                }

                Console.ForegroundColor = ConsoleColor.White;
                Console.WriteLine("Do you want to continue? (y/n): ");
                choice = char.Parse(Console.ReadLine());
            }
        }
    }
}
