using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace W4D2C1 {

    // T : Placeholder for dataType
    internal class Swap<T> {
        public static void SwapData(ref T num1, ref T num2) {
            T temp = num1;
            num1 = num2;
            num2 = temp;
        }
    }
}
