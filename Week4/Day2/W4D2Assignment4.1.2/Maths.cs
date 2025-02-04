using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using W4D2Assignment4._1._2.Interface;

namespace W4D2Assignment4._1._2 {
    internal class Maths : ICalculator {
        public static List<HistoryEntry> History = new List<HistoryEntry>();
        public int Add(int a, int b) {
            return a + b;
        }

        public int Divide(int a, int b) {
            return a / b;
        }

        public int Multiply(int a, int b) {
            return a * b;
        }

        public int Subtract(int a, int b) {
            return a - b;
        }
    }
}
