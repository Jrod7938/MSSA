namespace W5D3Assignment5._3 {
    internal class Solution {
        // You have a long flowerbed in which some of the plots are planted,
        // and some are not.However, flowers cannot be planted in adjacent plots.
        // Given an integer array flowerbed containing 0's and 1's, where 0 means
        // empty and 1 means not empty, and an integer n, return true if n new
        // flowers can be planted in the flowerbed without violating the
        // no-adjacent-flowers rule and false otherwise.
        // Example 1:
        // Input: flowerbed = [1, 0, 0, 0, 1], n = 1
        // Output: true
        // Example 2:
        // Input: flowerbed = [1, 0, 0, 0, 1], n = 2
        // Output: false
        internal static void Part1() {
            int size = GetInput<int>("Enter the size of the flowerbed: ");
            int[] flowerbed = new int[size];
            for(int i = 0; i < flowerbed.Length; i++) {
                flowerbed[i] = GetInput<int>($"Enter 0 or 1 for FlowerBed[{i}]: ");
            }
            int amount = GetInput<int>("Enter the amount of flowers to place: ");
            Console.WriteLine(CanPlaceFlowers(flowerbed, amount));
        }

        private static bool CanPlaceFlowers(int[] flowerbed, int amount) {
            for(int i = 0; i < flowerbed.Length; i++) {
                if (flowerbed[i] == 0 && (i == 0 || flowerbed[i - 1] == 0) && (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) { // check left and right for 0
                    flowerbed[i] = 1;
                    amount--;
                }
            }
            return amount <= 0;
        }

        // You are climbing a staircase.It takes n steps to reach the top.
        // Each time you can either climb 1 or 2 steps.In how many distinct ways
        // can you climb to the top?
        // Example 1:
        // Input: n = 2
        // Output: 2
        // Explanation: There are two ways to climb to the top.
        // 1. 1 step + 1 step
        // 2. 2 steps
        // Example 2:
        // Input: n = 3
        // Output: 3
        // Explanation: There are three ways to climb to the top.
        // 1. 1 step + 1 step + 1 step
        // 2. 1 step + 2 steps
        // 3. 2 steps + 1 step
        internal static void Part2() {
            int stairs = GetInput<int>("Enter the amount of stairs: ");
            Console.WriteLine(ClimbStairs(stairs));
        }

        private static int ClimbStairs(int stairs) {
            if (stairs <= 1) return 1;

            int[] combos = new int[stairs + 1];

            combos[0] = 1; // base cases
            combos[1] = 1;

            for(int i = 2; i <= stairs; i++) { // dp
                combos[i] = combos[i - 1] + combos[i - 2];
            }

            return combos[stairs];
        }

        private static T GetInput<T>(string prompt) {
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