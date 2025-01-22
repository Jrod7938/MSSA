using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W2D2Assignment {
    internal class Program {
        static void Main(string[] args) {
            if(args.Length <= 1) {
                Console.WriteLine("Please provide multiple numbers");
                return;
            }
            Console.WriteLine($"Numbers are");
            foreach (string arg in args) {
                Console.Write(arg + " ");
            }
            Console.WriteLine();
            Solution.Start(args);
            Solution.Part3();
        }
    }
}
