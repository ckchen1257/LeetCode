using LeetCode.TopInterview150._121;

namespace LeetCode.UnitTest.TopInterview150._121
{
    public class SolutionTests
    {
        public static TheoryData<int[], int> TestCase()
        {
            return new TheoryData<int[], int>
            {
                { [7, 1, 5, 3, 6, 4], 5 },
                { [7, 6, 4, 3, 1], 0 },
                { [5, 7, 4, 5], 2 },
                { [5, 6, 4, 6], 2 }
            };
        }


        [Theory]
        [MemberData(nameof(TestCase))]
        public void MaxProfit(int[] prices, int expectedOutput)
        {
            // arrange
            var solution = new Solution();

            // act
            var output = solution.MaxProfit(prices);

            // assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
