namespace LeetCode.TopInterview150._274;

public class Solution
{
    public int HIndex(int[] nums)
    {
        var counts = new int[nums.Length];

        for (int i = 0; i < nums.Length; i++)
        {
            int place = nums[i];
            if (place > nums.Length)
            {
                place = nums.Length;
            }
            for (int j = 0; j < place; j++)
            {
                counts[j]++;
            }
        }
        int hIndex = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (counts[i] >= i + 1)
            {
                hIndex = i + 1;
            }
        }
        return hIndex;
    }
}
