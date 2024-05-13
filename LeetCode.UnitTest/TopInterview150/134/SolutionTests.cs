using LeetCode.TopInterview150._134;

namespace LeetCode.UnitTest.TopInterview150._134
{
    public class SolutionTests
    {
        public static TheoryData<int[], int[], int> TestCase()
        {
            return new TheoryData<int[], int[], int>
            {
                // -2, -2, -2, 3, 3
                // -1, -1, 1
                // 1, -3, 1, -2, 3
                { [1,2,3,4,5], [3,4,5,1,2], 3 },
                { [2,3,4], [3,4,3], -1 },
                { [5,1,2,3,4], [4,4,1,5,1], 4 },
                { [0,2,0], [1,0,0], 1 },
                { [1,1,1], [1,2,1], -1 },
                { [1], [1], 0 },
                { [1], [2], -1 }
            };
        }


        [Theory]
        [MemberData(nameof(TestCase))]
        public void CanCompleteCircuit(int[] gas, int[] cost, int expectedOutput)
        {
            // arrange
            var solution = new Solution();

            // act
            var output = solution.CanCompleteCircuit(gas, cost);

            // assert
            Assert.Equal(expectedOutput, output);
        }
    }
}
