namespace ClimbingStairs70
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ClimbStairs(9)); // 55
        }

        private static int ClimbStairs(int n) {
            if (n <= 1) return 1;
            int[] combos = new int[n + 1];
            combos[0] = 1;
            combos[1] = 1;

            for(int i = 2; i <= n; i++) {
                combos[i] = combos[i - 1] + combos[i - 2];
            }

            return combos[n];
        }
    }
}
