namespace LeetCode.TopInterview150._189;

public class Solution
{
    public void Rotate(int[] nums, int k)
    {
        int initialIndex = 0;
        int index = initialIndex;
        var num = nums[index];

        for (int i = 0; i < nums.Length; i++)
        {
            index = (index + k) % nums.Length;
            (num, nums[index]) = (nums[index], num);
            if (index == initialIndex)
            {
                initialIndex = (initialIndex + 1) % nums.Length;
                index = initialIndex;
                num = nums[index];
            }
        }
    }
}
