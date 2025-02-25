namespace W7D2C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            ShellSort(new int[] { 3, 5, 8, 9, 6, 2 });
        }

        // O(nlog(n))
        private static void ShellSort(int[] A) {
            int gap = A.Length / 2;
            int i,
                j;

            while (gap > 0) {
                i = gap;
                while (i < A.Length) {
                    int temp = A[i]; // number to be placed
                    j = i - gap;
                    while(j >= 0 && A[j] > temp) {
                        A[j+gap] = A[j];
                        j = j - gap;
                    }
                    A[j + gap] = temp; // final position for temp
                    i++;
                }
            }
        }
    }
}
