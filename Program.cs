using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 22, 32, 11, 19, 9, 10, 22 };
            var sorter = new MergeSortUtil(true);
            var result = sorter.Sort(numbers);
            foreach (var _val in result)
            {
                Console.Write(_val + " ");
            }
            Console.Read();
        }
    }
}
