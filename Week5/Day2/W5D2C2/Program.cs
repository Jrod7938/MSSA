namespace W5D2C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Iterative: ");
            PrintSquaresIteration(6);
            Console.WriteLine("\nTail Recursive: ");
            PrintSquaresTailRecursive(6);
            Console.WriteLine("\nHead Recursive: ");
            PrintSquaresHeadRecursive(6);
        }

        static void PrintSquaresIteration(int n) {
            while(n > 0) {
                Console.Write(n * n + " ");
                n--;
            }
        }

        static void PrintSquaresTailRecursive(int n) {
            if (n < 1) return;
            Console.Write(n * n + " ");
            PrintSquaresTailRecursive(n - 1);
        }
        static void PrintSquaresHeadRecursive(int n) {
            if (n < 1) return;
            PrintSquaresHeadRecursive(n - 1);
            Console.Write(n * n + " ");
        }
    }
}
