using System;
using System.Linq;

namespace W2D3Assignment2._4 {
    internal class Solution {
        /*
        Write a program in C# Sharp to find the sum of all array elements.
        Test Data :
        Input the number of elements to be stored in the array :3
        Input 3 elements in the array :
        element - 0 : 2
        element - 1 : 5
        element - 2 : 8
        Expected Output :
        Sum of all elements stored in the array is : 15
        */
        internal static void Part1() {
            Console.Write("Input the number of elements to be stored in the array seperated by spaces:");
            string input = Console.ReadLine();
            if (input == string.Empty) {
                Console.WriteLine("No input given");
                return;
            }
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();

            Sum(numbers);
        }

        private static void Sum(int[] numbers) {
            if (numbers.Length == 1) {
                Console.WriteLine($"Sum of all elements stored in the array is : {numbers[0]}");
                return;
            } else {
                int sum = 0;
                foreach (int number in numbers) {
                    sum += number;
                }
                Console.WriteLine($"Sum of all elements stored in the array is : {sum}");
            }
        }

        /*
        Write a C# Sharp program to find the largest of three numbers.
        Test Data :
        Input the 1st number :25
        Input the 2nd number :63
        Input the 3rd number :10
        Expected Output :
        The 2nd Number is the greatest among three
        */
        internal static void Part2() {
            Console.Write("Enter three numbers seperated by space: ");
            string input = Console.ReadLine();
            if (input == string.Empty) {
                Console.WriteLine("No input given");
                return;
            }
            int[] numbers = input.Split(' ').Select(int.Parse).ToArray();
            Largest(numbers);
        }

        private static void Largest(int[] numbers) {
            if (numbers.Length != 3) {
                Console.WriteLine("Please enter exactly three numbers");
                return;
            }
            int largest = numbers[0];
            for (int i = 1; i < numbers.Length; i++) {
                if (numbers[i] > largest) {
                    largest = numbers[i];
                }
            }
            Console.WriteLine($"The {Array.IndexOf(numbers, largest) + 1} Number is the greatest among three");
        }

        /*
        Write a C# Sharp program to accept a coordinate point in an XY coordinate system and determine in which quadrant the coordinate point lies.

        Test Data :

        Input the value for X coordinate :7

        Input the value for Y coordinate :9

        Expected Output :

        The coordinate point (7,9) lies in the First quadrant.
        */
        internal static void Part3() {
            Console.Write("Enter the value for X coordinate: ");
            int x = int.Parse(Console.ReadLine());

            Console.Write("Enter the value for Y coordinate: ");
            int y = int.Parse(Console.ReadLine());

            Quadrant(x, y);
        }

        private static void Quadrant(int x, int y) {
            if (x == 0 && y == 0) {
                Console.WriteLine($"The coordinate point ({x},{y}) lies at the origin.");
            } else if (x > 0 && y > 0) { // 1st
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the First quadrant.");
            } else if (x > 0 && y < 0) { // 2nd
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Second quadrant.");
            } else if (x < 0 && y < 0) { // 3rd
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Third quadrant.");
            } else { // 4th
                Console.WriteLine($"The coordinate point ({x},{y}) lies in the Fourth quadrant.");
            }
        }
    }
}