using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;

namespace MergeSort
{
    public class MergeSortUtil
    {
        private bool _isAscendingOrder = true;

        public MergeSortUtil(bool isAscendingOrder)
        {
            _isAscendingOrder = isAscendingOrder;
        }
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
        private int[] Merge(List<int> left, List<int> right)
        {
            var result = new List<int>();

            while (left.Count > 0 && right.Count > 0)
            {
                if (checkMergeCondition(left, right))
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

        private bool checkMergeCondition(List<int> left, List<int> right) => _isAscendingOrder ? left.First() <= right.First() : left.First() >= right.First();

        private static void MoveValueFromSourceToResult(List<int> input, List<int> result)
        {
            result.Add(input.First());
            input.RemoveAt(0);
        }
    }
}
