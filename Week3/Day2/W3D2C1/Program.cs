using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D2C1 {
    internal class Program {
        static void Main(string[] args) {
            //datatype[,] name = new datatype[rows,cols];
            float[,] cityTemperatures;

            // int[,,] ints = new int[2, 2, 2]; // 3D array

            Console.WriteLine("Enter the number of cities (rows)");
            int rows = int.Parse(Console.ReadLine());

            Console.WriteLine("Enter the temperatures received per city (cols)");
            int cols = int.Parse(Console.ReadLine());

            cityTemperatures = new float[rows, cols];
            Console.WriteLine($"Please enter {rows * cols} readings of temperature");
            
            for(int i = 0; i < rows; i++) { // outer
                for(int j = 0; j < cols; j++) { // inner
                    Console.Write($"City[{i}, {j}] = ");
                    cityTemperatures[i,j] = float.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("You entered");
            for(int i = 0; i < cityTemperatures.GetLength(0); i++) {
                for (int j = 0; j < cityTemperatures.GetLength(1); j ++) {
                    Console.Write(cityTemperatures[i, j] + "\t");
                }
                Console.WriteLine();
            }

        }
    }
}
