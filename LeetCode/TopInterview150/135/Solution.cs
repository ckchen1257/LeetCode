namespace LeetCode.TopInterview150._135;

public class Solution
{
    public int Candy(int[] ratings)
    {
        if (ratings.Length == 1)
        {
            return 1;
        }

        int[] playerCandies = new int[ratings.Length];
        int candies = 0;

        for (int i = 0; i < ratings.Length; i++)
        {
            SetPlayerCandy(i);
        }
        return candies;

        int SetPlayerCandy(int i)
        {
            int candy = playerCandies[i];
            if (candy > 0)
            {
                return candy;
            }

            if (i == 0)
            {
                candy = ratings[i] > ratings[i + 1] ? SetPlayerCandy(i + 1) + 1 : 1;
            }
            else if (i == ratings.Length - 1)
            {
                candy = ratings[i] > ratings[i - 1] ? SetPlayerCandy(i - 1) + 1 : 1;
            }
            else
            {
                bool isOverPrevious = ratings[i] > ratings[i - 1];
                bool isOverNext = ratings[i] > ratings[i + 1];

                candy = !isOverPrevious && !isOverNext ? 1 :
                    isOverPrevious && !isOverNext ? SetPlayerCandy(i - 1) + 1 :
                    !isOverPrevious && isOverNext ? SetPlayerCandy(i + 1) + 1 :
                    Math.Max(SetPlayerCandy(i - 1), SetPlayerCandy(i + 1)) + 1;
            }

            playerCandies[i] = candy;
            candies += candy;
            return candy;
        }
    }
}
