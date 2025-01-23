using System;
using System.Linq;

namespace W2D3C2 {
    internal class Program {
        static void Main(string[] args) {
            Console.Write("Enter numbers: ");
            string input = Console.ReadLine();

            if(input == string.Empty) return;

            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            Solution.BiggestNumber(numbers);
            Solution.SmallestNumber(numbers);
        }
    }
}
