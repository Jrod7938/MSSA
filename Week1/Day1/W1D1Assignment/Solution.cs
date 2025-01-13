using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D1Assignment {
    internal class Solution {

        // 1. Create a console application in C# to store and print personal details of a person like name,
        //    age and address on console screen. Make use of appropriate variables.
        public static void Part1() {
            string name;
            int age;
            string address;

            Console.WriteLine("Enter your name: ");
            name = Console.ReadLine();

            Console.WriteLine("Enter your age: ");
            age = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter your address: ");
            address = Console.ReadLine();

            Console.WriteLine($"Hello {name}, you are {age} years old and live in {address}. Nice to meet you.");
        }

        // 2. Write a C# program to print the sum of two numbers. Get the input from user.
        public static void Part2() {
            int num1, num2;

            Console.WriteLine("Enter a number: ");
            num1 = Convert.ToInt32(Console.ReadLine());

            Console.WriteLine("Enter another number: ");
            num2 = Convert.ToInt32(Console.ReadLine());

            int sum = num1 + num2;

            Console.WriteLine($"The sum of {num1} & {num2} is {sum}.");
        }

        // 3. Write a C# program to print the result of dividing two numbers. Print the quotient and remainder
        //    as well. Get the input from the user.
        public static void Part3() {
            int num3, num4;
            Console.WriteLine("Enter a number: ");
            num3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter another number: ");
            num4 = Convert.ToInt32(Console.ReadLine());

            int div = num3 / num4;
            int rem = num3 % num4;

            Console.WriteLine($"The division of {num3} & {num4} is: {div} and the remainder is: {rem}");
        }
    }
}
