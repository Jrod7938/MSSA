namespace W5D1C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(HappyNumber(19));
            Console.WriteLine(HappyNumber(2));
        }

        static bool HappyNumber(int number) {
            HashSet<int> numbers = new HashSet<int>();

            while(!numbers.Contains(number) && number != 1) {
                numbers.Add(number);
                number = SumOfDigits(number);
            }

            return number == 1;
        }

        static int SumOfDigits(int number) {
            int sum = 0;
            int currentDigit = 0;
            while(number > 0) {
                currentDigit = number % 10;
                sum += currentDigit * currentDigit;
                number = number / 10;
            }
            return sum;
        }
    }
}
