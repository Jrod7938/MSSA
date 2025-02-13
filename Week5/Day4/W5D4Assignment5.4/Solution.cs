namespace W5D4Assignment5._4 {
    internal class Solution {
        // Write a program in C# Sharp to display the individual digits of a given number using recursion.
        // Test Data :
        // Input any number : 1234
        // Expected Output :
        // The digits in the number 1234 are : 1 2 3 4
        internal static void Part1() {
            int number = GetInput<int>("Enter a number: ");
            DisplayDigits(number);
            Console.WriteLine();
        }

        private static void DisplayDigits(int number) {
            if (number == 0) return;
            DisplayDigits(number / 10);
            Console.Write(number % 10 + " ");
        }

        // Write a C# Sharp program to find the sum of the right diagonals of a matrix.
        // Test Data :
        // Input the size of the square matrix : 2
        // Input elements in the first matrix :
        // element - [0],[0] : 1
        // element - [0],[1] : 2
        // element - [1],[0] : 3
        // element - [1],[1] : 4
        // Expected Output :
        // The matrix is :
        // 1 2
        // 3 4
        // Addition of the right Diagonal elements is :5
        internal static void Part2() {
            int size = GetInput<int>("Enter the size of the matrix: ");
            int[,] matrix = new int[size, size];

            for (int i = 0; i < size; i++) {
                for (int j = 0; j < size; j++) {

                    matrix[i, j] = GetInput<int>($"element - [{i}],[{j}]: ");
                }
            }

            Console.WriteLine($"Additon of right Diagonal elements is: {DiagonalSum(matrix)}");
        }

        private static int DiagonalSum(int[,] matrix) {
            int sum = 0;
            for(int i = 0; i < matrix.GetLength(0); i++) {
                sum += matrix[i, matrix.GetLength(0) - 1 - i];
            }

            return sum;
        }

        private static T GetInput<T>(string prompt) { // helper function to get input from user
            Console.Write(prompt);
            try {
                return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            } catch (Exception exception) {
                Console.WriteLine(exception.Message);
                return GetInput<T>(prompt);
            }
        }
    }
}