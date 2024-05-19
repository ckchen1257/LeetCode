using LeetCode.TopInterview150._135;

namespace LeetCode.UnitTest.TopInterview150._135
{
    public class SolutionTests
    {
        public static TheoryData<int[], int> TestCase()
        {
            return new TheoryData<int[], int>
            {
                { [1,0,2], 5 },
                { [1,2,2], 4 }
            };
        }

        [Theory]
        [MemberData(nameof(TestCase))]
        public void Candy(int[] ratings, int expectedOutput)
        {
            // arrange
            var solution = new Solution();

            // act
            var output = solution.Candy(ratings);

            // assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
