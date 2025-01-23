using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D3C2 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter numbers: ");
            string input = Console.ReadLine();
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            Solution.BiggestNumber(numbers);
        }
    }
}
