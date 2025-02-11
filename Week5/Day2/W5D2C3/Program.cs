namespace W5D2C3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Sum by Iteration: " + SumOfNumbersIterative(25));
            Console.WriteLine("Sum by Recursion: " + SumOfNumbersRecursive(25));
        }

        /// <summary>
        /// This method calculates the sum of numbers from 1 to n using iteration.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int SumOfNumbersIterative(int n) {
            int sum = 0;
            int i = 1;
            while(i <= n) {
                sum += i;
                i++;
            }
            return sum;
        }

        /// <summary>
        /// This method calculates the sum of numbers from 1 to n using recursion.
        /// </summary>
        /// <param name="n"></param>
        /// <returns></returns>
        private static int SumOfNumbersRecursive(int n) {
            if (n == 1) return n;
            return n + SumOfNumbersRecursive(n - 1);
        }
    }
}
