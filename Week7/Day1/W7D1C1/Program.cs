namespace W7D1C1 {
    internal class Program {
        static void Main(string[] args) {
            SelectionSort(new int[] { 5, 3, 9, 8, 6, 2 });
        }

        static void SelectionSort(int[] array) {
            int minIndex = 0; // track min index
            int temp = 0;
            for (int i = 0; i < array.Length - 1; i++) {
                minIndex = i;
                for (int j = i + 1; j < array.Length; j++) { // get min element index 
                    if (array[j] < array[minIndex]) {
                        minIndex = j; // update min index
                    }
                }
                if (minIndex != i) { // swap
                    temp = array[i];
                    array[i] = array[minIndex];
                    array[minIndex] = temp;
                }
            }
        }
    }
}
