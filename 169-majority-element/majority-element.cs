public class Solution {
    public int MajorityElement(int[] nums) {
        int candidate = 0;
        int count = 0;
        int read = 0;

        if(nums.Length == 1){
            return nums[0];
        }

        while(read < nums.Length){
            if(count == 0){
                candidate = nums[read];
            }

            if(nums[read] == candidate){
                count++;
            }
            else{
                count--;
            }

            read++;
        }

        return candidate;
    }
}