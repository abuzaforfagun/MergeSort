using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public class MergeSortUtil
    {
        public int[] Sort(int[] inputArray)
        {
            if (inputArray.Length <= 1)
            {
                return inputArray;
            }

            var left = new List<int>();
            var right = new List<int>();
            for (int i = 0; i < inputArray.Length; i++)
            {
                if (i % 2 == 0)
                    left.Add(inputArray[i]);
                else
                    right.Add(inputArray[i]);
            }

            left = Sort(left.ToArray()).ToList();
            right = Sort(right.ToArray()).ToList();

            return Merge(left, right);
        }
        private static int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (left.First() <= right.First())
                {
                    MoveValueFromSourceToResult(left, result);
                }
                else
                {
                    MoveValueFromSourceToResult(right, result);
                }
            }
            if (left.Count > 0)
            {
                MoveValueFromSourceToResult(left, result);
            }
            else
            {
                MoveValueFromSourceToResult(right, result);
            }
            return result.ToArray();
        }

        private static void MoveValueFromSourceToResult(List<int> input, List<int> result)
        {
            result.Add(input.First());
            input.RemoveAt(0);
        }
    }
}
