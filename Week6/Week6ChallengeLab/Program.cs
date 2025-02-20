namespace Week6ChallengeLab
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int[,] matrix = new int[3, 3] { { 1, 2, 3 }, { 4, 5, 6 }, { 7, 8, 9 } };
            Console.WriteLine("Before Rotation: ");
            PrintMatrix(matrix);

            Console.WriteLine("After Rotation: ");
            ClockWiseRotation(matrix);
            PrintMatrix(matrix);
        }

        private static void ClockWiseRotation(int[,] matrix) {
            for(int i = 0; i < matrix.GetLength(0); i++) { // transpose
                for(int j = i + 1; j < matrix.GetLength(1); j++) {
                    (matrix[i, j], matrix[j, i]) = (matrix[j, i], matrix[i, j]);
                }
            }

            for(int i = 0; i < matrix.GetLength(0); i++) { // reverse
                int left = 0,
                    right = matrix.GetLength(0) - 1;
                while(left < right) {
                    (matrix[i, left], matrix[i, right]) = (matrix[i, right], matrix[i, left]);
                    left++;
                    right--;
                }
            }
        }

        private static void PrintMatrix(int[,] matrix) {
            for(int i = 0; i < matrix.GetLength(0); i++) {
                for(int j = 0; j < matrix.GetLength(1); j++) {
                    Console.Write(matrix[i,j] + " ");
                }
                Console.WriteLine();
            }
            Console.WriteLine();
        }
    }
}
