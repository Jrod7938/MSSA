namespace Week11ChallengeLabs {
    internal class Solution {
        public static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            string input = Console.ReadLine();
            return (T)Convert.ChangeType(input, typeof(T));
        }

        public static void Part1() {
            int n = GetInput<int>("Enter number of elements: ");
            int[] nums = new int[n];
            for (int i = 0; i < n; i++)
                nums[i] = GetInput<int>($"Enter element {i + 1}: ");

            int low = 0, 
                mid = 0, 
                high = n - 1;
            while (mid <= high) {
                if (nums[mid] == 0) {
                    int temp = nums[low];
                    nums[low] = nums[mid];
                    nums[mid] = temp;
                    low++;
                    mid++;
                } else if (nums[mid] == 1) {
                    mid++;
                } else if (nums[mid] == 2) {
                    int temp = nums[mid];
                    nums[mid] = nums[high];
                    nums[high] = temp;
                    high--;
                }
            }
            Console.WriteLine(string.Join(",", nums));
        }

        public static void Part2() {
            string text = GetInput<string>("Enter text: ");
            int[] freq = new int[26];
            foreach (char c in text.ToLower())
                if (char.IsLetter(c))
                    freq[c - 'a']++;

            int count = Math.Min(Math.Min(freq['b' - 'a'], freq['a' - 'a']),
                        Math.Min(freq['l' - 'a'] / 2,
                        Math.Min(freq['o' - 'a'] / 2, freq['n' - 'a'])));
            Console.WriteLine(count);
        }
    }
}