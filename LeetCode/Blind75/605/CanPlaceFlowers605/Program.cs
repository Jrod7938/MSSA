namespace CanPlaceFlowers605
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(CanPlaceFlowers(new int[] {1, 0, 0, 0, 0, 0, 1}, 2));
        }

        private static bool CanPlaceFlowers(int[] flowerbed, int n) {
            for(int i = 0; i < flowerbed.Length; i++) {
                if (flowerbed[i] == 0 && 
                    (i == 0 || flowerbed[i - 1] == 0) && // check left
                    (i == flowerbed.Length - 1 || flowerbed[i + 1] == 0)) { // check right
                    flowerbed[i] = 1;
                    n--;
                }
            }
            return n <= 0;
        }
    }
}
