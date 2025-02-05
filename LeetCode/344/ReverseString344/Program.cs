
namespace ReverseString344
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] s = { 'H', 'a', 'n', 'n', 'a', 'h' };
            ReverseString(s);
            Console.WriteLine(s);
        }

        private static void ReverseString(char[] s) {
            int i = 0;
            int j = s.Length - 1;

            while (i <= j) {
                (s[i], s[j]) = (s[j], s[i]);
                i++;
                j--;
            }
        }
    }
}
