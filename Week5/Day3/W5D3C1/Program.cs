namespace W5D3C1
{
    internal class Program
    {
        static Nullable<long>[] sequence = new Nullable<long>[100];
        static void Main(string[] args)
        {
            FibonacciIteration(8);
            Console.WriteLine();
            Console.WriteLine(FibonacciRecursive(8));
            Console.WriteLine(FibonacciDynamicProgramming(8));
        }

        private static int FibonacciIteration(int number) {
            int first = 0, 
                second = 1, 
                result = 0;

            if (number == 0) return 0;
            if(number == 1) {
                Console.Write(0);
                return 1;
            }
            Console.Write("0" + ", 1, ");
            for(int i = 2; i < number; i++) {
                result = first + second;
                Console.Write(result + ", ");
                (first, second) = (second, result); // move to the right
            }
            return result;
        }

        private static int FibonacciRecursive(int number) {
            if (number <= 1) return number;
            return FibonacciRecursive(number - 1) + FibonacciRecursive(number - 2);
        }

        static long? FibonacciDynamicProgramming(int number) {
            if (number <= 1)
                return number;

            long[] fib = new long[number + 1];
            fib[0] = 0;
            fib[1] = 1;

            for (int i = 2; i <= number; i++) {
                fib[i] = fib[i - 1] + fib[i - 2];
            }

            return fib[number];
        }
    }
}
