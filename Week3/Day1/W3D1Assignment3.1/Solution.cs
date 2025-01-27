using System;
using System.Text;

namespace W3D1Assignment3._1 {
    internal class Solution {
        /*
        Return even numbers
        Write a method that returns a string of even numbers greater than 0 and less than 100.
        Use StringBuilder class
        Expected input and output
        ReturnEvenNumbers() → "2 4 6 8 10 12 14 16 18 20 22 24 26 28 30 32 34 36 38 40 42 44 46 48 50 52 54 56 58 60 62 64 66 68 70 72 74 76 78 80 82 84 86 88 90 92 94 96 98"
        */
        internal static void Part1() {
            Console.WriteLine(EvenNumbers());
        }

        private static string EvenNumbers() {
            StringBuilder sb = new StringBuilder();
            for(int i = 1; i <100; i++) {
                if (i % 2 == 0) sb.Append($"{i} ");
            }
            return sb.ToString().Trim();
        }

        /*
        If year is leap
        Given a year as integer, write a method that checks if year is leap.
        Expected input and output
        IfYearIsLeap(2016) → true IfYearIsLeap(2018) → false
        */
        internal static void Part2() {
            int year = GetInput<int>("Enter the year to check: ");
            Console.WriteLine(isLeapYear(year));
        }

        private static bool isLeapYear(int year) {
            return (year % 4 == 0 && (year % 100 != 0 || year % 400 == 0));
        }

        /*
        Write a program in C# Sharp to create a function to input a string and count number of spaces are in the string.
        Test Data :
        Please input a string : This is a test string.
        Expected Output :
        "This is a test string." contains 4 spaces
        */
        internal static void Part3() {
            string input = GetInput<string>("Please input a string: ");
            Console.WriteLine($"\"{input}\" contains {CountSpaces(input)} spaces");
        }

        private static int CountSpaces(string input) {
            int count = 0;
            foreach(char letter in input) {
                if (letter == ' ') count++;
            }
            return count;
        }

        /*
        Write a function which takes an array as input and finds the first occurrence of 2 consecutive 1s and changes their value to 0.
        For e.g: Input : [0,2,1,1,9,1,1]
        Output: [0,2,0,0,9,1,1]
        */
        internal static void Part4() {
            int arrayLength = GetInput<int>("How many numbers in array: ");
            int[] numbers = new int[arrayLength];
            for(int i = 0; i<arrayLength; i++) {
                int number = GetInput<int>("Enter an int: ");
                numbers[i] = number;
            }
           
            Console.WriteLine(OnesToZeros(numbers));
        }

        private static string OnesToZeros(int[] numbers) {
            for(int i = 0; i < numbers.Length - 1; i++) {
                if (numbers[i] == 1 && numbers[i + 1] == 1) {
                    numbers[i] = 0;
                    numbers[i + 1] = 0;
                    break;
                }
            }
            StringBuilder sb = new StringBuilder();
            sb.Append("[");
            foreach (int number in numbers) sb.Append($"{number}, ");
            sb.Length -= 2; // trims the trailing ", "
            sb.Append("]");
            return sb.ToString();
        }

        private static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            string input = Console.ReadLine();
            try {
                var userInput = Convert.ChangeType(input, typeof(T));
                return (T)userInput;
            } catch (Exception exception) {
                Console.WriteLine($"Please input a value of type {typeof(T).Name}\nError {exception.Message}");
                return GetInput<T>(prompt);
            }
        }
    }
}