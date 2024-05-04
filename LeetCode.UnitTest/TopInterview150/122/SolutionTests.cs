using LeetCode.TopInterview150._122;

namespace LeetCode.UnitTest.TopInterview150._122
{
    public class SolutionTests
    {
        public static TheoryData<int[], int> TestCase()
        {
            return new TheoryData<int[], int>
            {
                { [7, 1, 5, 3, 6, 4], 7 },
                { [1, 2, 3, 4, 5], 4 },
                { [7, 6, 4, 3, 1], 0 }
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
