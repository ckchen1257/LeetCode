namespace LeetCode.TopInterview150._45;

public class Solution
{
    public int Jump(int[] nums)
    {
        if (nums.Length == 1)
        {
            return 0;
        }

        for (int i = nums.Length - 2; i >= 0; i--)
        {
            int minSteps = 0;
            for (int j = 1; j <= nums[i]; j++)
            {
                if (i + j >= nums.Length - 1)
                {
                    minSteps = 1;
                    continue;
                }
                if (nums[i + j] == 0)
                {
                    continue;
                }
                if (minSteps == 0 || minSteps > nums[i + j] + 1)
                {
                    minSteps = nums[i + j] + 1;
                }
            }
            nums[i] = minSteps;
        }
        return nums[0];
    }
}
