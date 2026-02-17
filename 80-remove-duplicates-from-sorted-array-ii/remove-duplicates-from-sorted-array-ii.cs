public class Solution {
    int read = 0;
    int write = 0;
    int occurence = 0;

    public int RemoveDuplicates(int[] nums) {

        while (read < nums.Length) {
            int temp = nums[read];
            occurence = 0;

            while (read < nums.Length && nums[read] == temp) {
                occurence++;
                read++;
            }
            
            nums[write++] = temp;
            
            if (occurence >= 2) {
                nums[write++] = temp;
            }
        }

        return write;
    }
}