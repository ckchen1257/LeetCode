using LeetCode.TopInterview150._274;

namespace LeetCode.UnitTest.TopInterview150._274
{
    public class SolutionTests
    {
        public static TheoryData<int[], int> TestCase()
        {
            return new TheoryData<int[], int>
            {
                { [3, 0, 6, 1 , 5], 3 },
                { [1, 3, 1], 1 }
            };
        }


        [Theory]
        [MemberData(nameof(TestCase))]
        public void HIndex(int[] nums, int expectedValue)
        {
            // arrange
            var solution = new Solution();

            // act
            var output = solution.HIndex(nums);

            // assert
            Assert.Equal(expectedValue, output);
        }
    }
}
