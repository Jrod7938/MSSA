namespace W10D4C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = GetInput<int>("Enter Size of array: ");
            int[] array = new int[size]; // [100, 4, 200, 1, 3, 2]

            for (int i = 0; i < array.Length; i++) array[i] = GetInput<int>($"Enter number[{i}]: ");

            Console.WriteLine(LongestConsecutive(array));
        }

        private static int LongestConsecutive(int[] nums) {
            if (nums.Length < 1) return 0;

            HashSet<int> numberSet = new HashSet<int>(nums); // O(1) lookup
            int answer = 0;

            foreach(int number in numberSet) {
                if(!numberSet.Contains(number - 1)) { // sequence start, lowest number
                    int currentNumber = number;
                    int counter = 1;

                    while(numberSet.Contains(currentNumber + 1)) { // Continue checking the next number in the sequence
                        currentNumber++;
                        counter++;
                    }

                    answer = Math.Max(answer, counter); // Update the longest sequence found
                }
            }

            return answer;
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
