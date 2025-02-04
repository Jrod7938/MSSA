using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D2C2 {
    internal class MathCalc : IMath {
        public int Add(params int[] numbers) {
            int total = 0;
            foreach (int number in numbers) total += number;
            return total;
        }

        public int Subtract(params int[] numbers) {
            int total = 0;
            foreach (int number in numbers) total -= number;
            return total;
        }
    }
}
