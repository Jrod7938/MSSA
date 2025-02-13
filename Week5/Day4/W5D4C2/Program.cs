namespace W5D4C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int size = GetInput<int>("Enter amount of houses: ");
            int[] houses = new int[size];

            for(int i = 0; i < houses.Length; i++) {
                houses[i] = GetInput<int>($"Enter money at house[{i}]: ");
            }

            Console.WriteLine(Rob(houses));
        }

        public static int Rob(int[] nums) {
            if (nums.Length == 0) return 0;
            if (nums.Length == 1) return nums[0];

            int maxMoneyPrevHouse = 0, // max money robbed previous house
                maxMoneyTwoHousesAgo = 0; // max money robbed 2 houses ago

            foreach(int currentHouseMoney in nums) {
                int tempMax = maxMoneyPrevHouse; // store previous max
                maxMoneyPrevHouse = Math.Max(maxMoneyTwoHousesAgo + currentHouseMoney, maxMoneyPrevHouse); // get max between houses not adjacent 
                maxMoneyTwoHousesAgo = tempMax; 
            }

            return maxMoneyPrevHouse;
        }

        private static T GetInput<T>(string prompt) { // helper function to get input from user
            Console.Write(prompt);
            try {
                return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            }catch(Exception exception) {
                Console.WriteLine(exception.Message);
                return GetInput<T>(prompt);
            }
        }
    }
}
