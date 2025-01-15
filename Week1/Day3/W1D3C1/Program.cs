using System;

namespace W1D3C1 {
    internal class Program {
        static void Main(string[] args) {

            int[] numbers = new int[5]; // allocate memory for 5 elements

            numbers[0] = 1;
            numbers[1] = 2;
            numbers[2] = 3;
            numbers[3] = 4;
            numbers[4] = 5;

            Console.WriteLine("Array Demo");
            Console.WriteLine("Enter 5 numbers");
            for (int i = 0; i < numbers.Length; i++) {
                numbers[i] = int.Parse(Console.ReadLine());
            }

            Console.WriteLine("\nNumbers in Array");
            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine($"Numbers[{i}] = {numbers[i]}");
            }

            Array.Reverse(numbers);
            Console.WriteLine("\nNumbers in Array Reversed");
            for (int i = 0; i < numbers.Length; i++) {
                Console.WriteLine($"Numbers[{i}] = {numbers[i]}");
            }

            Console.WriteLine("\nArray of Names");
            string[] names = { "John", "Doe", "Jane" };
            Array.Sort(names);
            foreach(string name in names) {
                Console.WriteLine(name);
            }

            float[] temperatures = { 56.6f, 66f, 70.4f };

            Console.WriteLine("\nArray of Temperatures");
            Array.Resize(ref temperatures, 5);
            foreach(float temp in temperatures) {
                Console.WriteLine(temp);
            }
        }
    }
}
