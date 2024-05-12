namespace LeetCode.TopInterview150._55;

public class Solution
{
    public bool CanJump(int[] nums)
    {
        int goalIndex = nums.Length - 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            if (i + nums[i] >= goalIndex)
            {
                goalIndex = i;
            }
        }
        return goalIndex == 0;
    }

    public bool CanJump_1(int[] nums)
    {
        int lastIndex = nums.Length - 1;

        bool[] isSuccess = new bool[nums.Length];
        isSuccess[lastIndex] = true;

        for (int i = lastIndex - 1; i >= 0; i--)
        {
            if (i + nums[i] > lastIndex)
            {
                isSuccess[i] = true;
            }
            for (int j = 1; j <= nums[i]; j++)
            {
                if (isSuccess[i + j])
                {
                    isSuccess[i] = true;
                    break;
                }
            }
        }
        return isSuccess[0];
    }
}
