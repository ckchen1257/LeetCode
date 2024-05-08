using LeetCode.TopInterview150._380;

namespace LeetCode.UnitTest.TopInterview150._380
{
    public class RandomizedSetTests
    {
        private const double _testSuccessRate = 1.0 / 10000;

        public static TheoryData<(Func<RandomizedSet, bool> Func, bool ExpectedResult)[], HashSet<int>> TestCase()
        {
            return new TheoryData<(Func<RandomizedSet, bool> Func, bool ExpectedResult)[], HashSet<int>>()
            {
                {
                    [
                        ((set) => set.Insert(1), true),
                        ((set) => set.Remove(2), false),
                        ((set) => set.Insert(2), true),
                        ((set) => set.Remove(1), true),
                        ((set) => set.Insert(1), true),
                        ((set) => set.Insert(2), false),
                        ((set) => set.Insert(3), true),
                        ((set) => set.Insert(4), true),
                        ((set) => set.Insert(5), true),
                        ((set) => set.Insert(6), true),
                        ((set) => set.Insert(7), true),
                        ((set) => set.Insert(8), true),
                        ((set) => set.Insert(9), true),
                        ((set) => set.Insert(10), true)
                    ],
                    [ 1, 2, 3, 4, 5, 6, 7, 8, 9, 10 ]
                }
            };
        }

        [Theory]
        [MemberData(nameof(TestCase))]
        public void RandomizedSet((Func<RandomizedSet, bool> Func, bool ExpectedResult)[] actionResultPairs, HashSet<int> nums)
        {
            // arrange
            double numCount = nums.Count;
            double randomTimes = (int)(Math.Log(_testSuccessRate) / Math.Log((numCount - 1) / numCount)) + 1;
            var randomizedSet = new RandomizedSet();

            // act & assert
            foreach (var pair in actionResultPairs)
            {
                var results = pair.Func(randomizedSet);
                Assert.Equal(pair.ExpectedResult, results);
            }

            // assert
            HashSet<int> randomNums = [];
            for (int i = 0; i < randomTimes; i++)
            {
                randomNums.Add(randomizedSet.GetRandom());
            }
            Assert.Equal(nums, randomNums);
        }
    }
}
