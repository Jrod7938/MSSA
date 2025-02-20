namespace ProductofArrayExceptSelf238
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] nums = { 1, 2, 3, 4 };
            int[] result = ProductExceptSelf(nums);
            Console.WriteLine(string.Join(", ", result));

        }

        public static int[] ProductExceptSelf(int[] nums) {
            int[] answer = new int[nums.Length];

            answer[0] = 1;
            for (int i = 1; i < nums.Length; i++) { // prefix
                answer[i] = answer[i - 1] * nums[i - 1];
            }

            int suffix = 1;
            for (int i = nums.Length - 1; i >= 0; i--) { // product
                answer[i] *= suffix;
                suffix *= nums[i];
            }

            return answer;
        }
    }
}
