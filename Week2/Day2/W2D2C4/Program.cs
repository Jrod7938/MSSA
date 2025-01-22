using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2C4 {
    internal class Program {
        static void Main(string[] args) {
            const double tipRate = 0.18;

            if(args.Length == 0 || !double.TryParse(args[0], out double billTotal)) {
                Console.WriteLine("Please enter the bill amount.");
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
