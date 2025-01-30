
namespace W3D4C2 {
    internal class Solution {

        internal static int BuyChocolate(ref int[] ints, int money) {
            Array.Sort(ints);

            if (ints.Length < 2) return money;

            int minValueCost = ints[0] + ints[1];

            if(minValueCost <= money) {
                return money - minValueCost;
            }

            return money;
        }
    }
}