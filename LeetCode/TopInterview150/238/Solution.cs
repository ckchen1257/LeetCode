namespace LeetCode.TopInterview150._238;

public class Solution
{
    public int[] ProductExceptSelf(int[] nums)
    {
        var zeroCount = nums.Count(num => num == 0);
        if (zeroCount > 1)
        {
            for (int i = 0; i < nums.Length; i++)
            {
                nums[i] = 0;
            }
        }
        else if (zeroCount > 0)
        {
            var aggregate = nums.Where(num => num != 0).Aggregate((accumulatedNum, num) => accumulatedNum * num);
            for (int i = 0; i < nums.Length; i++)
            {
                if (nums[i] == 0)
                {
                    nums[i] = aggregate;
                }
                else
                {
                    nums[i] = 0;
                }
            }
        }
        else
        {
            var aggregate = nums.Aggregate((accumulatedNum, num) => accumulatedNum * num);

            if (aggregate != 0)
            {
                for (int i = 0; i < nums.Length; i++)
                {
                    nums[i] = aggregate / nums[i];
                }
            }
        }
        return nums;
    }

    public int[] ProductExceptSelf_V3(int[] nums)
    {
        int aggregate = 1;
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] != 0)
            {
                aggregate *= nums[i];
                continue;
            }

            for (int j = i + 1; j < nums.Length; j++)
            {
                aggregate *= nums[j];
                if (aggregate == 0)
                {
                    break;
                }
            }
            for (int j = 0; j < nums.Length; j++)
            {
                nums[j] = 0;
            }
            nums[i] = aggregate;
            return nums;
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = aggregate / nums[i];
        }
        return nums;
    }

    public int[] ProductExceptSelf_V2(int[] nums)
    {
        // 1. Calculate the left product of each element
        int[] results = new int[nums.Length];
        results[0] = 1;
        for (int i = 1; i < nums.Length; i++)
        {
            results[i] = results[i - 1] * nums[i - 1];
        }

        // 2. Calculate the right product of each element and multiply it with the left product
        int rightNum = 1;
        for (int i = nums.Length - 2; i >= 0; i--)
        {
            rightNum *= nums[i + 1];
            results[i] *= rightNum;
        }

        return results;
    }

    public int[] ProductExceptSelf_V1(int[] nums)
    {
        int[] leftNums = new int[nums.Length];
        leftNums[0] = 1;
        for (int i = 0; i < nums.Length - 1; i++)
        {
            leftNums[i + 1] = leftNums[i] * nums[i];
        }

        int[] rightNums = new int[nums.Length];
        rightNums[nums.Length - 1] = 1;
        for (int i = nums.Length - 1; i > 0; i--)
        {
            rightNums[i - 1] = rightNums[i] * nums[i];
        }

        for (int i = 0; i < nums.Length; i++)
        {
            nums[i] = leftNums[i] * rightNums[i];
        }

        return nums;
    }
}
