using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MergeSort
{
    public class MergeSortInput
    {
        public static void DoMergeSort(int[] numbers)
        {
            var sortestNumbers = MergeSort(numbers);
            for (int i = 0; i < numbers.Length; i++)
            {
                numbers[i] = sortestNumbers[i];
            }
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

            while (ListNotEmpty(left) && ListNotEmpty(right))
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
            if (ListNotEmpty(left))
            {
                MoveValueFromSourceToResult(left, result);
            }
            else
            {
                MoveValueFromSourceToResult(right, result);
            }
            return result.ToArray();
        }

        private static bool ListNotEmpty(List<int> list)
        {
            return list.Count > 0;
        }

        private static void MoveValueFromSourceToResult(List<int> list, List<int> result)
        {
            result.Add(list.First());
            list.RemoveAt(0);
        }
    }
}
