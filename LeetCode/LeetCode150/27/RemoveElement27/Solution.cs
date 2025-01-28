using System.Diagnostics;

static class Solution{
    public static int RemoveElement(int[] nums, int val){
        int pointer = 0;

        for(int i =0; i < nums.Length; i++){
            if(nums[i] != val){
                nums[pointer] = nums[i];
                pointer++;
            }
        }
        return pointer;
    }
}