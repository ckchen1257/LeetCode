using LeetCode.TopInterview150._189;

namespace LeetCode.UnitTest.TopInterview150._189
{
    public class SolutionTests
    {
        public static TheoryData<int[], int, int[]> TestCase()
        {
            return new TheoryData<int[], int, int[]>
            {
                { [1, 2, 3, 4, 5, 6, 7], 3, [5, 6, 7, 1, 2, 3, 4] },
                { [-1, -100, 3, 99], 2, [3, 99, -1, -100] },
                { [1, 2, 3, 4, 5, 6], 3, [4, 5, 6, 1, 2, 3]},
                { [1], 0, [1] }
            };
        }


        [Theory]
        [MemberData(nameof(TestCase))]
        public void Rotate(int[] nums, int k, int[] expectedNums)
        {
            // arrange
            var solution = new Solution();

            // act
            solution.Rotate(nums, k);

            // assert
            Assert.Equal(expectedNums, nums);
        }
    }
}
