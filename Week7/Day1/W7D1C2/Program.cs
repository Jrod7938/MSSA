namespace W7D1C2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            InsertionSort(new int[] { 3, 5, 9, 8, 6, 2});
        }

        static void InsertionSort(int[] array) {
            int temp = 0;
            int position = 0;

            for(int i = 0; i < array.Length; i++) {
                temp = array[i];
                position = i;
                while(position > 0 && array[position - 1] > temp) {
                    array[position] = array[position - 1];
                    position--;
                }
                array[position] = temp;
            }
        }
    }
}
