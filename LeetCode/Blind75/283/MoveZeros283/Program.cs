
namespace MoveZeros283
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 0, 1, 0, 3, 12 };
            MoveZeroes(nums);
            foreach (var num in nums) {
                Console.Write(num + " ");
            }
        }

        private static void MoveZeroes(int[] nums) {
            int pointer = 0;
            for (int i = 0; i < nums.Length; i++) {
                if (nums[i] != 0) {
                    (nums[i], nums[pointer]) = (nums[pointer], nums[i]);
                    pointer++;
                }
            }
        }
    }
}
