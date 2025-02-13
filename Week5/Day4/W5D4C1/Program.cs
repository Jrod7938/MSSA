namespace W5D4C1
{
    internal class Program {
        static void Main(string[] args) {
            Console.WriteLine(LinearSearch(new int[] { 10, 12, 15, 4, 12, 9 }, 4));
            Console.WriteLine(BinarySearch(new int[] { 0, 1, 2, 3, 12, 13, 32, 33, 45 }, 33));
        }

        static int LinearSearch(int[] array, int val) { // O(n)
            for(int i = 0; i < array.Length; i++) {
                if (array[i] == val) {
                    return i;
                }
            }
            return -1;
        }

        static int BinarySearch(int[] sortedArray, int val) { // O(logn)
            int left = 0;
            int right = sortedArray.Length - 1;

            while(left <= right) {
                int mid = left + (right - left) / 2; // to avoid integer overflow we perform subtraction first. Same as (left + right) / 2

                if (sortedArray[mid] == val) return mid;
                else if (sortedArray[mid] < val) left = mid + 1;
                else right = mid - 1;
            }

            return -1;
        }
    }
}
