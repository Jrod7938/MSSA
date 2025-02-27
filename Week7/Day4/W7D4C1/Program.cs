namespace W7D4C1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[] A = { 34, 12, 1, 45, 9, 11 };
            Divide(A, 0, A.Length - 1);
            foreach (int num in A) Console.Write(num + " ");
        }

        static void Divide(int[] A, int left, int right) {
            if(left < right) {
                int mid = (left + right) / 2;
                Divide(A, left, mid);
                Divide(A, mid + 1, right);
                Merge(A, left, mid, right);
            }
        }

        static void Merge(int[] A, int left, int mid, int right) {
            int i = left; // first index of sub array
            int j = mid + 1; // first index of right sub array
            int[] temp = new int[right + 1]; // temp array to hold merged elements
            int k = left; // index to track the elements in array B
            
            while(i <= mid && j <= right) {
                if (A[i] <= A[j]) {
                    temp[k] = A[i];
                    i++;
                } else {
                    temp[k] = A[j];
                    j++;
                }
                k++;
            }

            while(i <= mid) { // more elements in left array
                temp[k] = A[i];
                i++;
                k++;
            }

            while(j <= right) { // mmore elements in right array
                temp[k] = A[j];
                j++;
                k++;
            }

            for(int x = left; x <= right; x++) {
                A[x] = temp[x]; // put array back sorted
            }
        }
    }
}
