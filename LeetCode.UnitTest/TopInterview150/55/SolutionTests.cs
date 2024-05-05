using LeetCode.TopInterview150._55;

namespace LeetCode.UnitTest.TopInterview150._55
{
    public class SolutionTests
    {
        public static TheoryData<int[], bool> TestCase()
        {
            return new TheoryData<int[], bool>
            {
                { [2, 3, 1, 1, 4], true },
                { [3, 2, 1, 0, 4], false },
                { [0], true },
                { [2, 2, 0, 0], true }
            };
        }


        [Theory]
        [MemberData(nameof(TestCase))]
        public void CanJump(int[] nums, bool expectedValue)
        {
            // arrange
            var solution = new Solution();

            // act
            var output = solution.CanJump(nums);

            // assert
            Assert.Equal(expectedValue, output);
        }
    }
}
