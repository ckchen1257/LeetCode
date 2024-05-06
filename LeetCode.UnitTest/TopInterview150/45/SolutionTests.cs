using LeetCode.TopInterview150._45;

namespace LeetCode.UnitTest.TopInterview150._45
{
    public class SolutionTests
    {
        public static TheoryData<int[], int> TestCase()
        {
            return new TheoryData<int[], int>
            {
                { [2, 3, 1, 1, 4], 2 },
                { [2, 3, 0, 1, 4], 2 },
                { [0], 0 },
                { [1], 0 },
                { [1, 1, 1, 1], 3 },
                { [5, 9, 3, 2, 1, 0, 2, 3, 3, 1, 0, 0], 3 }
            };
        }


        [Theory]
        [MemberData(nameof(TestCase))]
        public void Jump(int[] nums, int expectedValue)
        {
            // arrange
            var solution = new Solution();

            // act
            var output = solution.Jump(nums);

            // assert
            Assert.Equal(expectedValue, output);
        }
    }
}
