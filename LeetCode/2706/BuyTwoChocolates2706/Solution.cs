internal static class Solution{
    public static int BuyChoco(int[] prices, int money){
        int min = int.MaxValue;
        int min2 = int.MaxValue;
        for(int i = 0; i < prices.Length; i++){
            if(prices[i] < min){
                min2 = min;
                min = prices[i];
            } else if(prices[i] < min2){
                min2 = prices[i];
            }
        }
        return (money >= min + min2) ? money - (min + min2) : money;
    }
}