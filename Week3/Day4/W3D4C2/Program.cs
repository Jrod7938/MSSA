namespace W3D4C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int sizeOfArray = GetInput<int>("Please Enter The Size of Array: ");
            int[] chocolatePrices = new int[sizeOfArray];

            for (int i = 0; i < chocolatePrices.Length; i++){
                int input = GetInput<int>($"Please enter a number for [{i}]: ");
                chocolatePrices[i] = input;
            }
            int money = GetInput<int>("Enter the amount of money: ");
            Console.WriteLine(Solution.BuyChocolate(ref chocolatePrices, money));
        }

        static T GetInput<T>(string prompt) {
            Console.Write(prompt);
            string input = Console.ReadLine();
            try {
                var userInput = Convert.ChangeType(input, typeof(T));
                return (T)userInput;
            } catch (Exception exception){
                Console.WriteLine($"Invalid input, Please input value of type {typeof(T).Name}\nError Message: {exception.Message}");
                return GetInput<T>(prompt);
            }
        }
    }
}
