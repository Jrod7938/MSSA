namespace W4D3Assignment4._3 {
    internal static class Solution {
        // Write a program in C# Sharp to calculate and print the Electricity 
        // bill of a given customer. The customer id., name and unit consumed 
        // by the user should be taken from the keyboard and display the total 
        // amount to pay to the customer. The charge are as follows: (you may 
        // change the charge sheet values) If bill exceeds $ 400 then a 
        // surcharge of 15% will be charged.
        // Test Data :
        // 1001
        // James
        // 800
        // Expected Output :
        // Customer IDNO :1001
        // Customer Name :James
        // unit Consumed :800
        // Amount Charges @$ 2.00 per unit : 1600.00
        // Surcharge Amount : 240.00
        // Net Amount Paid By the Customer : 1840.00
        public static void Part1() {
            int customerId = GetInput<int>("Enter Customer ID: ");
            string customerName = GetInput<string>("Enter Customer Name: ");
            int unitsConsumed = GetInput<int>("Enter Units Consumed: ");

            Customer customer = new Customer(customerId, customerName, unitsConsumed);
            customer.DisplayBill();
        }

        // Write a program in C# Sharp to count the frequency of each element of an array.
        // Test Data :
        // Input the number of elements to be stored in the array :3
        // Input 3 elements in the array :
        // element - 0 : 25
        // element - 1 : 12
        // element - 2 : 43
        // Expected Output :
        // Frequency of all elements of array :
        // 25 occurs 1 times
        // 12 occurs 1 times
        // 43 occurs 1 times
        public static void Part2() {
            int size = GetInput<int>("Enter size of array: ");
            int[] array = new int[size];

            for (int i = 0; i < size; i++) {
                array[i] = GetInput<int>($"element - {i} : ");
            }

            Dictionary<int, int> frequency = CountFrequencies(array);

            Console.WriteLine("\nFrequency of all elements of array:");
            foreach (var pair in frequency) {
                Console.WriteLine($"{pair.Key} occurs {pair.Value} times");
            }
        }

        private static Dictionary<int, int> CountFrequencies(int[] array) {
            Dictionary<int, int> frequency = new Dictionary<int, int>();
            foreach (int num in array) {
                if (frequency.ContainsKey(num)) {
                    frequency[num]++;
                } else {
                    frequency[num] = 1;
                }
            }
            return frequency;
        }


        // Write a program in C# Sharp to print all unique elements in an array.
        // Test Data :
        // Input the number of elements to be stored in the array :3
        // Input 3 elements in the array :
        // element - 0 : 1
        // element - 1 : 5
        // element - 2 : 1
        // Expected Output :
        // The unique elements found in the array are : 5
        public static void Part3() {
            int size = GetInput<int>("Enter size of array: ");
            int[] array = new int[size];

            for (int i = 0; i < size; i++) {
                array[i] = GetInput<int>($"element - {i} : ");
            }

            List<int> unequeElements = GetUniqueElements(array);
            Console.WriteLine($"The unique elements found in the array are: {(unequeElements.Count > 0 ? string.Join(" ", unequeElements) : "None")}");
        }

        private static List<int> GetUniqueElements(int[] array) {
            Dictionary<int, int> frequency = CountFrequencies(array);
            List<int> uniqueElements = new List<int>();
            foreach (var pair in frequency) {
                if (pair.Value == 1) {
                    uniqueElements.Add(pair.Key);
                }
            }
            return uniqueElements;
        }

        private static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            try {
                return (T)Convert.ChangeType(Console.ReadLine(), typeof(T));
            } catch (Exception exception) {
                Console.WriteLine($"Invalid input. Please try again.\n{exception.Message}");
                return GetInput<T>(prompt);
            }
        }
    }
}
