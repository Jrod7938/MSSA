namespace HouseRobber198
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Rob(new int[] { 2, 7, 9, 3, 1 }));
        }
        
        private static int Rob(int[] nums) {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int maxMoneyPrevHouse = 0, // max money robbed previous house
                maxMoneyTwoHousesAgo = 0; // max money robbed 2 houses ago

            foreach (int currentHouseMoney in nums) {
                int tempMax = maxMoneyPrevHouse; // store previous max
                maxMoneyPrevHouse = Math.Max(maxMoneyTwoHousesAgo + currentHouseMoney, maxMoneyPrevHouse); // get max between houses not adjacent 
                maxMoneyTwoHousesAgo = tempMax;
            }

            return maxMoneyPrevHouse;
        }
    }
}
