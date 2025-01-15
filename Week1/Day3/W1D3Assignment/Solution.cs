using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W1D3Assignment {
    internal class Solution {
        /*
         * Write a program in C# to calculate area of triangle, 
         * square and rectangle. Write 3 different functions 
         * for each shape to take dimensions of figure and 
         * display the area. You may create menus.
         */
        public static void Part1() {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine("Calculate Area of...\n1. Triangle\n2. Square\n3. Rectangle");

            int.TryParse(Console.ReadLine(), out int selection);

            switch (selection) {
                case 1:
                    Console.Write("What is the base length: ");
                    int.TryParse(Console.ReadLine(), out int num1);
                    Console.Write("What is the height: ");
                    int.TryParse(Console.ReadLine(), out int num2);
                    Console.WriteLine($"Base: {num1}\nHeight: {num2}\nArea: {AreaOfTriangle(num1, num2)}");
                    break;
                case 2:
                    Console.Write("What is the length of one side: ");
                    int.TryParse(Console.ReadLine(), out int side);
                   
                    Console.WriteLine($"Side: {side}\nArea: {AreaOfSquare(side)}");
                    break;
                case 3:
                    Console.WriteLine("What is the width: ");
                    int.TryParse(Console.ReadLine(), out int width);
                    Console.WriteLine("What is the length: ");
                    int.TryParse(Console.ReadLine(), out int length);
                    Console.WriteLine($"Width: {width}\nLength: {length}\nArea: {AreaOfRectangle(width, length)}");
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    Part1();
                    break;
            }
        }

        private static float AreaOfTriangle(float baseLength, float heightLength) {
            return (heightLength * baseLength) / 2;
        }

        private static float AreaOfSquare(float side) {
            return side * side;
        }

        private static float AreaOfRectangle(float width, float length) {
            return width * length;
        }

        /*
         * Write a console application in C# to explore different ways 
         * in which array is declared and initialized and explore different
         * properties and methods of Array class.
         */
        public static void Part2() {
            Console.ForegroundColor = ConsoleColor.DarkBlue;
            Console.Write("How Long Would You Like to Make This Array? ");
            int.TryParse(Console.ReadLine(), out int size);
        arrayType:
            Console.Write("What Would You Like To Store In This Array?(string, int, double, float) ");
            var type = Console.ReadLine();
            switch (type?.ToLower()) {
                case "string":
                    string[] strArr = new string[size];
                    OpperationsOnArray(strArr);
                    break;
                case "int":
                    int[] intArr = new int[size];
                    OpperationsOnArray(intArr);
                    break;
                case "double":
                    double[] doubleArr = new double[size];
                    OpperationsOnArray(doubleArr);
                    break;
                case "float":
                    float[] floatArr = new float[size];
                    OpperationsOnArray(floatArr);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    goto arrayType;
            }
        }

        private static void OpperationsOnArray<T>(T[] arr) {

            Console.WriteLine("Fill the array with values");

            for (int i = 0; i < arr.Length; i++) {
                Console.Write($"Value in {i}: ");
                string input = Console.ReadLine();
                arr[i] = (T)Convert.ChangeType(input, typeof(T));
            }

            Console.WriteLine("\nContents of Array");
            PrintArray(arr);

        OpperationsOnArray:
            Console.WriteLine("\nWhat opperation would you like to perform?\n1. Reverse\n2. Sort\n3. Resize");
            int.TryParse(Console.ReadLine(), out int selection);

            switch (selection) {
                case 1:
                    arr.Reverse();
                    PrintArray(arr);
                    break;
                case 2:
                    Array.Sort(arr);
                    PrintArray(arr);
                    break;
                case 3:
                    Console.Write("What size?: ");
                    int.TryParse(Console.ReadLine(), out int size);
                    Array.Resize(ref arr, size);
                    PrintArray(arr);
                    break;
                default:
                    Console.WriteLine("Invalid Selection");
                    goto OpperationsOnArray;
            }
            
        }

        private static void PrintArray<T>(T[] arr) {
            for (int i = 0; i < arr.Length; i++) {
                Console.WriteLine($"Array[{i}]: {arr[i]}");
            }
        }

        public static void Part3() {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.Write("How many numbers to store?: ");
            int.TryParse(Console.ReadLine(), out int size);

            int[] arr = new int[size];

            Console.WriteLine($"Input {size} numbers");
            for(int i = 0; i < size; i++) {
                Console.Write($"Array[{i}] = ");
                int.TryParse(Console.ReadLine(), out arr[i]);
            }

            Console.WriteLine("\nThe Values in the Reversed Array are:");
            Array.Reverse(arr);
            PrintArray(arr);
        }
    }
}
