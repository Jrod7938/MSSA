using System;

namespace ExtraCredit {
    public class Solution {

        // Write a C# Sharp program that takes four numbers as input to calculate and print the average. 
        public static void Part1() {
            Console.WriteLine("Enter 4 Numbers");
            int.TryParse(Console.ReadLine(), out int num1);
            int.TryParse(Console.ReadLine(), out int num2);
            int.TryParse(Console.ReadLine(), out int num3);
            int.TryParse(Console.ReadLine(), out int num4);

            Console.WriteLine($"The average is: {(num1 + num2 + num3 + num4) / 4}");
        }

        // check two given integers and return true if one is negative and one is positive.   
        public static void Part2() {
            Console.WriteLine("Enter a number");
            int.TryParse(Console.ReadLine(), out int num1);
            Console.WriteLine("Enter a number");
            int.TryParse(Console.ReadLine(), out int num2);

            if(num1 > 0 && num2 < 0 || num1 < 0 && num2 > 0) {
                Console.WriteLine("True");
            } else {
                Console.WriteLine("False");
            }
        }

        // Circumference of a circle
        public static void Part3(float radius) {
            Console.WriteLine($"Circumference of Circle: {2 * Math.PI * radius}");
        }

        // Check if even or odd
        public static void Part4(int number) {
            if (number % 2 == 0) Console.WriteLine($"{number} is Even");
            else Console.WriteLine($"{number} is Odd");
        }

        // right angle triangle with numbers
        public static void Part5(int rows) {
            if (rows < 1) return;

            int number = 1;
            for(int i=1; i < rows; i++) {
                for(int j=1; j<=i; j++) {
                    Console.Write($"{number} ");
                    number++;
                }
                Console.WriteLine();
            }
        }

        // displays the n terms of square natural numbers and their sum.
        public static void Part6(int numbers) {
            int sum = 0;
            Console.Write($"The square natural up to {numbers} are: ");
            for(int i= 1; i <= numbers; i++) {
                Console.Write($"{i * i} ");
                sum += i * i;
            }
            Console.WriteLine($"\nThe sum of Square Natural Number upto {numbers} is {sum}.");
        }
    }
}