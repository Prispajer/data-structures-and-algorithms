public class Solution {
    public void Rotate(int[] nums, int k) {
        k %= nums.Length;

        int[] result = nums[^k..].Concat(nums[..^k]).ToArray();

        for (int i = 0; i < nums.Length; i++){
            nums[i] = result[i];
        }
    }
}