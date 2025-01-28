using System;

namespace W3D2Assignment3._2 {
    internal class Solution {

        /*
        Create a 2D array to store integers and print them in matrix format with proper formatting.
        e. g:
        | 2 | 3 | 4 |
        | 1 | 4 | 6 |
        */
        internal static void Part1() {
            int rows = GetInput<int>("How many rows: ");
            int columns = GetInput<int>("How many columns: ");
            int[,] matrix = new int[rows, columns];
            for (int i = 0; i < rows; i++) {
                for (int j = 0; j < columns; j++) {
                    int number = GetInput<int>($"Enter a number for [{i},{j}]");
                    matrix[i, j] = number;
                }
            }

            PrintMatrix(matrix);
        }

        private static void PrintMatrix(int[,] matrix) {
            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write($"| {matrix[i, j]} ");
                }
                Console.Write("|");
                Console.WriteLine();
            }
        }


        /*
        Write a program in C# Sharp for addition of two Matrices of same size.
        Test Data :
        Input the size of the square matrix (less than 5): 2
        Input elements in the first matrix :
        element - [0],[0] : 1
        element - [0],[1] : 2
        element - [1],[0] : 3
        element - [1],[1] : 4
        Input elements in the second matrix :
        element - [0],[0] : 5
        element - [0],[1] : 6
        element - [1],[0] : 7
        element - [1],[1] : 8
        Expected Output:
        The First matrix is:
        1 2
        3 4
        The Second matrix is :
        5 6
        7 8
        The Addition of two matrix is :
        6 8
        10 12
        */
        internal static void Part2() {
            int size = GetInput<int>("Enter the size of the square matrix: ");
            int[,] matrix1 = new int[size, size];
            int[,] matrix2 = new int[size, size];

            Console.WriteLine("Matrix 1 Elements");
            for (int i = 0; i < matrix1.GetLength(0); i++) {
                for (int j = 0; j < matrix1.GetLength(1); j++) {
                    int number = GetInput<int>($"Enter a number for Matrix1[{i},{j}]: ");
                    matrix1[i, j] = number;
                }
            }

            Console.WriteLine("Matrix 2 Elements");
            for (int i = 0; i < matrix2.GetLength(0); i++) {
                for (int j = 0; j < matrix2.GetLength(1); j++) {
                    int number = GetInput<int>($"Enter a number for Matrix2[{i},{j}]: ");
                    matrix2[i, j] = number;
                }
            }
            MatrixAdditon(matrix1, matrix2);
        }

        private static void MatrixAdditon(int[,] matrix1, int[,] matrix2) {
            int[,] matrix = new int[matrix1.GetLength(0), matrix1.GetLength(1)];

            for (int i = 0; i < matrix.GetLength(0); i++) {
                for (int j = 0; j < matrix.GetLength(1); j++) {
                    matrix[i, j] = matrix1[i, j] + matrix2[i, j];
                }
            }

            PrintMatrix(matrix);
        }

        /*
        Create a console application to overload 
        “+” and “-“ operator for adding the areas 
        of 2 circles and getting their area difference 
        respectively.
        */
        internal static void Part3() {
            int radius1 = GetInput<int>("Enter the radius for the first circle: ");
            int radius2 = GetInput<int>("Enter the radius for the second circle: ");

            Circle circle1 = new Circle(radius1);
            Circle circle2 = new Circle(radius2);

            Console.WriteLine($"Total Area of Circle 1 and Circle 2: {circle1 + circle2}");
            Console.WriteLine($"Area Difference between Circle 1 and Circle 2: {circle1 - circle2}");
        }

        /*
        Write a function that takes 4 numbers as input to calculate the total and average.
        (Make use of params array to pass arguments and out parameters to return both total and average to main method).
        Test Data:
        Enter the First number: 10
        Enter the Second number: 15
        Enter the third number: 20
        Enter the fourth number: 30
        Expected Output:
        The average of 10 , 15 , 20 , 30 is: 18.75
        The total is 75
        */
        internal static void Part4() {
            int num1 = GetInput<int>("Enter a number: ");
            int num2 = GetInput<int>("Enter a number: ");
            int num3 = GetInput<int>("Enter a number: ");
            int num4 = GetInput<int>("Enter a number: ");

            Calculate(out int total, out double average, num1, num2, num3, num4);

            Console.WriteLine($"Total: {total}\tAverage: {average}");
        }

        static void Calculate(out int total, out double average, params int[] nums) {
            total = 0;

            foreach (int num in nums) {
                total += num;
            }
            average = (double)total / nums.Length;
        }

        /*
        Create a function that finds the index of a given item in the array
        Examples
        Search([1, 5, 3], 5) ➞ 1
        Search([9, 8, 3], 3) ➞ 2
        Search([1, 2, 3], 4) ➞ -1
        Notes
        If the item is not present, return -1.
        */
        internal static void Part5() {
            int size = GetInput<int>("Length of Array: ");
            int[] array = new int[size];
            for (int i = 0; i < array.Length; i++) {
                array[i] = GetInput<int>($"Enter a number for [{i}]: ");
            }

            int num = GetInput<int>("Enter the number to search for: ");

            Search(array, num);
        }

        static void Search(int[] array, int num) {
            for (int i = 0; i < array.Length; i++) {
                if (array[i] == num) {
                    Console.WriteLine($"{i}");
                    return;
                }
            }
            Console.WriteLine("-1");
        }

        private static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            string input = Console.ReadLine();
            try {
                var userInput = Convert.ChangeType(input, typeof(T));
                return (T)userInput;
            } catch (Exception exception) {
                Console.WriteLine($"Please enter an input of type {typeof(T).Name}\nError Message: {exception.Message}");
                return GetInput<T>(prompt);
            }
        }
    }
}