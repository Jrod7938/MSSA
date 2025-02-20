namespace RotateImage48
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[][] matrix = new int[][] {
                new int[] {1, 2, 3},
                new int[] {4, 5, 6},
                new int[] {7, 8, 9}
            };
            Rotate(matrix);
        }

        public static void Rotate(int[][] matrix) {
            for (int i = 0; i < matrix.Length; i++) { // transpose
                for (int j = i + 1; j < matrix.Length; j++) {
                    int temp = matrix[i][j];
                    matrix[i][j] = matrix[j][i];
                    matrix[j][i] = temp;
                }
            }

            for (int i = 0; i < matrix.Length; i++) { // reverse
                Array.Reverse(matrix[i]);
            }
        }
    }
}
