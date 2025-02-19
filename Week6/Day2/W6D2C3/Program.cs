namespace W6D2C3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] array = { 23, 1, 45, 2, 12, 99 };
            BubbleSort(array);
            foreach (int number in array) Console.WriteLine(number);
        }

        public static void BubbleSort(int[] array) {
            for(int pass = array.Length - 1; pass >= 0; pass--) {
                for(int i=0; i < pass; i++) {
                    if (array[i] > array[i + 1]) {
                        (array[i], array[i + 1]) = (array[i + 1], array[i]);
                    }
                }
            }
        }
    }
}
