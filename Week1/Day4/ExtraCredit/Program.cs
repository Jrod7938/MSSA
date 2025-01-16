using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ExtraCredit {
    internal class Program {
        static void Main(string[] args) {
            Solution.Part1();

            Solution.Part2();


            Console.Write("Enter a radius: ");
            int.TryParse(Console.ReadLine(), out int radius);
            Solution.Part3(radius);

            Console.Write("Enter a number: ");
            int.TryParse(Console.ReadLine(), out int number);
            Solution.Part4(number);

            Console.Write("Enter amount of rows: ");
            int.TryParse(Console.ReadLine(), out int rows);
            Solution.Part5(rows);

            Console.Write("Enter amount of terms to display natural numbers: ");
            int.TryParse(Console.ReadLine(), out int terms);
            Solution.Part6(terms);
        }
    }
}
