namespace W5D4C2 {
    internal class Program {
        static void Main(string[] args) {
            int size = GetInput<int>("Enter amount of houses: ");
            int[] houses = new int[size];

            for (int i = 0; i < houses.Length; i++) {
                houses[i] = GetInput<int>($"Enter money at house[{i}]: ");
            }

            Console.WriteLine(Solution.Rob(houses));
        }

        private static T GetInput<T>(string prompt) { // helper function to get input from user
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
