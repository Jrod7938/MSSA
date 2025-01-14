using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D2Assignment {
    internal class Solution {

        /*
           Write a C# Sharp program to accept two integers and check whether they are equal or not.
           Test Data :
           Input 1st number: 5
           Input 2nd number: 5
           Expected Output :
           5 and 5 are equal
           Test Data :
           Input 1st number: 5
           Input 2nd number: 15
           Expected Output :
           5 and 15 are not equal
        */
        public static void Part1() {
            Console.Write("Input 1st number: ");
            int number1 = int.Parse(Console.ReadLine());

            Console.Write("Input 2nd number: ");
            int number2 = int.Parse(Console.ReadLine());

            Equal(number1, number2);
        }


        /*
           Write a C# Sharp program to find the sum of first 10 natural numbers.
           Expected Output :
           The first 10 natural number is :
           1 2 3 4 5 6 7 8 9 10
           The Sum is : 55
         */
        public static void Part2() {
            int sum = 0;
            for (int i = 1; i <= 10; i++) {
                sum += i;
            }

            Console.WriteLine($"The Sum is: {sum}");
        }

        /*
           Write a menu driven application to perform calculation functions like 
           addition, subtraction, multiplication, and division. Call them 
           appropriately when user selects the option. Give the user the option 
           to continue or exit the program.
         */
        public static void Part3() {
            bool calculate = true;

            while (calculate) {
                Calculator();
                Console.WriteLine("Continue? Y or N");
                char response = char.Parse(Console.ReadLine().ToLower());
                if(response != 'y') {
                    calculate = false;
                }
            }
        }

        private static void Equal(int number1, int number2) {
            if(number1 == number2) {
                Console.WriteLine($"{number1} and {number2} are equal");
            } else {
                Console.WriteLine($"{number1} and {number2} are not equal");
            }
        }

        private static void Calculator() {
            Console.Write("Enter a number: ");
            int number1 = int.Parse(Console.ReadLine());
            Console.WriteLine("Make A Selection (1,2,3,4)");
            Console.WriteLine("1. Addition");
            Console.WriteLine("2. Subtraction");
            Console.WriteLine("3. Multiply");
            Console.WriteLine("4. Divide");
            int operation = int.Parse(Console.ReadLine());

            Console.Write("Enter a second number: ");
            int number2 = int.Parse(Console.ReadLine());

            switch (operation) {
                case 1:
                    Console.WriteLine($"{number1} + {number2} is {Add(number1, number2)}");
                    break;
                case 2:
                    Console.WriteLine($"{number1} - {number2} is {Subtract(number1, number2)}");
                    break;
                case 3:
                    Console.WriteLine($"{number1} * {number2} is {Multiplication(number1, number2)}");
                    break;
                case 4:
                    Console.WriteLine($"{number1} / {number2} is {Division(number1, number2)}");
                    break;
            }


        }

        private static int Add(int number1, int number2) {
            return number1 + number2;
        }

        private static int Subtract(int number1, int number2) {
            return number1 - number2;
        }

        private static int Multiplication(int number1, int number2) {
            return number1 * number2;
        }

        private static double Division(int number1, int number2) {
            return number1 / number2;
        }

    }
}
