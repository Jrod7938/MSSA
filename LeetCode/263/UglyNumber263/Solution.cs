
namespace UglyNumber263 {
    internal class Solution {
        internal static bool IsUgly(int n) {
            if (n <= 0) return false;
            int[] primes = { 2, 3, 5 };

            foreach(int prime in primes) {
                while(n % prime == 0) { // n is divisible by prime
                    n /= prime; // divide n by prime
                }
            }
            return n == 1;
        }
    }
}