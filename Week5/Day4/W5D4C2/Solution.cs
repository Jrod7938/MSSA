namespace W5D4C2 {
    internal static class Solution {
        public static int Rob(int[] nums) {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int maxMoneyPrevHouse = 0, // max money robbed previous house
                maxMoneyTwoHousesAgo = 0; // max money robbed 2 houses ago

            foreach (int currentHouseMoney in nums) {
                int tempMax = maxMoneyPrevHouse; // store previous max (i-1)
                maxMoneyPrevHouse = Math.Max(maxMoneyTwoHousesAgo + currentHouseMoney, maxMoneyPrevHouse); // get max between houses not adjacent 
                maxMoneyTwoHousesAgo = tempMax; // move i-2 forward
            }

            return maxMoneyPrevHouse;
        }
    }
}
