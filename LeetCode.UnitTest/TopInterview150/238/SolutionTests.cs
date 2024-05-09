using LeetCode.TopInterview150._238;

namespace LeetCode.UnitTest.TopInterview150._238
{
    public class SolutionTests
    {
        public static TheoryData<int[], int[]> TestCase()
        {
            return new TheoryData<int[], int[]>
            {
                { [1, 2, 3, 4], [24, 12, 8, 6] },
                { [-1, 1, 0, -3 , 3], [0, 0, 9, 0, 0] }
            };
        }


        [Theory]
        [MemberData(nameof(TestCase))]
        public void ProductExceptSelf(int[] nums, int[] expectedNums)
        {
            // arrange
            var solution = new Solution();

            // act
            var output = solution.ProductExceptSelf(nums);

            // assert
            Assert.Equal(expectedNums, output);
        }
    }
}
