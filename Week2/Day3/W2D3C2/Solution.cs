using System;

namespace W2D3C2 {
    internal class Solution {
        internal static void BiggestNumber(int[] ints) {
            if(ints.Length < 1) return;
            if (ints.Length == 1) {
                Console.WriteLine(ints[0]);
                return;
            }

            int biggest = ints[0];
            for(int i = 1; i < ints.Length; i++) {
                if (ints[i] > biggest) biggest = ints[i];
            }
            Console.WriteLine(biggest);
        }

        internal static void SmallestNumber(int[] ints) {
            if (ints.Length < 1) return;
            if (ints.Length == 1) {
                Console.WriteLine(ints[0]);
                return;
            }
            int smallest = ints[0];
            for (int i = 1; i < ints.Length; i++) {
                if (ints[i] < smallest) smallest = ints[i];
            }
            Console.WriteLine(smallest);
        }
    }
}