using System;
using Xunit;

namespace MergeSort.Tests
{
    public class MergeSortUtilTests
    {
        [Fact]
        public void DoSort_Should_SortTheInputs_In_AscendingOrder()
        {
            var util = new MergeSortUtil(true);
            int[] inputs = { 10, 22, 32, 11, 19, 9, 10, 22 };
            int[] expectedResult = { 9, 10, 10, 11, 19, 22, 22, 32 };

            var result = util.Sort(inputs);

            Assert.Equal(result, expectedResult);
        }

        [Fact]
        public void DoSort_Should_SortTheInputs_In_DescendingOrder()
        {
            var util = new MergeSortUtil(false);
            int[] inputs = { 10, 22, 32, 11, 19, 9, 10, 22 };
            int[] expectedResult = { 32, 22, 22, 19, 11, 10, 10, 9 };

            var result = util.Sort(inputs);

            Assert.Equal(result, expectedResult);
        }
    }
}
