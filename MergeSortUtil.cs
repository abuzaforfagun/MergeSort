using System.Collections.Generic;
using System.Linq;

namespace MergeSort
{
    public class MergeSortUtil
    {
        private int[] _inputArray;

        public MergeSortUtil(int[] inputArray)
        {
            _inputArray = inputArray;
        }
        public int[] Sort()
        {
            var sortestNumbers = MergeSort(_inputArray);
            for (int i = 0; i < _inputArray.Length; i++)
            {
                _inputArray[i] = sortestNumbers[i];
            }

            return _inputArray;
        }
        private static int[] MergeSort(int[] numbers)
        {
            if(numbers.Length <= 1)
            {
                return numbers;
            }

            var left = new List<int>();
            var right = new List<int>();
            for (int i = 0; i < numbers.Length; i++)
            {
                if (i % 2 == 0)
                    left.Add(numbers[i]);
                else
                    right.Add(numbers[i]);
            }

            left = MergeSort(left.ToArray()).ToList();
            right = MergeSort(right.ToArray()).ToList();

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
