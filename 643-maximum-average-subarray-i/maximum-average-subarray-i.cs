public class Solution
{
    public double FindMaxAverage(int[] nums, int k)
    {
        int read = 0;
        int start = 0;
        int result = 0;
        bool windowReady = false;
        double maxAverage = double.MinValue;

        if (k >= nums.Length)
        {
            long sum = 0;
            for (int i = 0; i < nums.Length; i++)
                sum += nums[i];

            return (double)sum / k;
        }

        while (read < nums.Length)
        {
            if (read < k)
            {
                result += nums[read];
                read++;

                if (read == k)
                    windowReady = true;
            }
            else
            {
                result = result + nums[read] - nums[start];
                start++;
                read++;
            }

            if (windowReady && result > maxAverage)
                maxAverage = result;
        }

        return maxAverage / k;
    }
}