
namespace W3D4C2 {
    internal class Solution {

        internal static int BuyChocolate(int[] ints, int money) {
            if (ints.Length < 2) return money;
            
            Array.Sort(ints);

            int minValueCost = ints[0] + ints[1];

            if(minValueCost <= money) {
                return money - minValueCost;
            }

            return money;
        }
    }
}