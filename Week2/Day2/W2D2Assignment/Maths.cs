using System;

namespace W2D2Assignment {
    internal static class Maths {
        public static void Add(int num1, int num2) {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public static void Add(int[] numbers) {
            int sum = 0;
            foreach (int number in numbers) {
                sum += number;
            }
            Console.WriteLine($"Sum of numbers: {sum}");
        }
        
        public static void Add(double num1, double num2) {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public static void Add(double[] numbers) {
            double sum = 0;
            foreach (double number in numbers) {
                sum += number;
            }
            Console.WriteLine($"Sum of numbers: {sum}");
        }

        public static void Add(float num1, float num2) {
            Console.WriteLine($"{num1} + {num2} = {num1 + num2}");
        }

        public static void Add(float[] numbers) {
            float sum = 0;
            foreach (float number in numbers) {
                sum += number;
            }
            Console.WriteLine($"Sum of numbers: {sum}");
        }

        public static void Subtract(int num1, int num2) {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

        public static void Subtract(int[] ints) {
            int sum = ints[0];
            for (int i = 1; i < ints.Length; i++) {
                sum -= ints[i];
            }
            Console.WriteLine($"Subtraction of numbers: {sum}");
        }

        public static void Subtract(double num1, double num2) {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

        public static void Subtract(double[] doubles) {
            double sum = doubles[0];
            for (int i = 1; i < doubles.Length; i++) {
                sum -= doubles[i];
            }
            Console.WriteLine($"Subtraction of numbers: {sum}");
        }

        public static void Subtract(float num1, float num2) {
            Console.WriteLine($"{num1} - {num2} = {num1 - num2}");
        }

        public static void Subtract(float[] floats) {
            float sum = floats[0];
            for (int i = 1; i < floats.Length; i++) {
                sum -= floats[i];
            }
            Console.WriteLine($"Subtraction of numbers: {sum}");
        }

        public static void Multiply(int num1, int num2) {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }

        public static void Multiply(int[] ints) {
            int product = 1;
            foreach (int number in ints) {
                product *= number;
            }
            Console.WriteLine($"Product of numbers: {product}");
        }

        public static void Multiply(double num1, double num2) {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }

        public static void Multiply(double[] doubles) {
            double product = 1;
            foreach (double number in doubles) {
                product *= number;
            }
            Console.WriteLine($"Product of numbers: {product}");
        }

        public static void Multiply(float num1, float num2) {
            Console.WriteLine($"{num1} * {num2} = {num1 * num2}");
        }

        public static void Multiply(float[] floats) {
            float product = 1;
            foreach (float number in floats) {
                product *= number;
            }
            Console.WriteLine($"Product of numbers: {product}");
        }

        public static void Divide(int num1, int num2) {
            if (num2 == 0) {
                Console.WriteLine("Cannot divide by zero");
                return;
            }
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }

        public static void Divide(int[] ints) {
            int quotient = ints[0];
            for (int i = 1; i < ints.Length; i++) {
                if (ints[i] == 0) {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
                quotient /= ints[i];
            }
            Console.WriteLine($"Division of numbers: {quotient}");
        }

        public static void Divide(double num1, double num2) {
            if (num2 == 0) {
                Console.WriteLine("Cannot divide by zero");
                return;
            }
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }

        public static void Divide(double[] doubles) {
            double quotient = doubles[0];
            for (int i = 1; i < doubles.Length; i++) {
                if (doubles[i] == 0) {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
                quotient /= doubles[i];
            }
            Console.WriteLine($"Division of numbers: {quotient}");
        }

        public static void Divide(float num1, float num2) {
            if (num2 == 0) {
                Console.WriteLine("Cannot divide by zero");
                return;
            }
            Console.WriteLine($"{num1} / {num2} = {num1 / num2}");
        }

        public static void Divide(float[] floats) {
            float quotient = floats[0];
            for (int i = 1; i < floats.Length; i++) {
                if (floats[i] == 0) {
                    Console.WriteLine("Cannot divide by zero");
                    return;
                }
                quotient /= floats[i];
            }
            Console.WriteLine($"Division of numbers: {quotient}");
        }
    }
}