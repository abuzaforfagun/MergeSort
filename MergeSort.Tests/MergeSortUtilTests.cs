using System;
using Xunit;

namespace MergeSort.Tests
{
    public class MergeSortUtilTests
    {
        [Fact]
        public void DoSort_Should_SortTheInputs_InCorrectWay()
        {
            var util = new MergeSortUtil();
            int[] inputs = { 10, 22, 32, 11, 19, 9, 10, 22 };
            int[] expectedResult = { 9, 10, 10, 11, 19, 22, 22, 32 };

            var result = util.Sort(inputs);

            Assert.Equal(result, expectedResult);
        }
    }
}
