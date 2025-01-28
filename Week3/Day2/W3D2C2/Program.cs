using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W3D2C2 {
    internal class Program {
        static void Main(string[] args) {
            
            int[][] tempCities = new int[4][]; // decide the number of rows (cities)

            for(int i = 0; i < tempCities.Length; i++) {
                Console.WriteLine($"Enter the number of readings you expect for city {i}");
                int numCities = int.Parse(Console.ReadLine());

                tempCities[i] = new int[numCities]; // allocate size by creeating array and adding it to cities
                for(int j = 0; j < tempCities[i].Length; j++) {
                    Console.WriteLine($"Enter the temperature for [{i},{j}]");
                    tempCities[i][j] = int.Parse(Console.ReadLine());
                }
            }

            Console.WriteLine("Jagged array");
            for (int i = 0; i < tempCities.Length; i++) {
                for(int j = 0; j < tempCities[i].Length; j++) {
                    Console.Write(tempCities[i][j] + "F\t");
                }
                Console.WriteLine();
            }
        }
    }
}
