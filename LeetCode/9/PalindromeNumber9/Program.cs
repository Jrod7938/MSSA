
namespace PalindromeNumber9
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(IsPalindrome(121));
            Console.WriteLine(IsPalindrome(-121));
            Console.WriteLine(IsPalindrome(10));
        }

        private static bool IsPalindrome(int x) {
            if (x < 0) return false;
            int original = x;
            int reversed = 0;
            
            while(x > 0) {
                int digit = x % 10;
                reversed = reversed * 10 + digit;
                x /= 10;
            }

            return original == reversed;
        }
    }
}
