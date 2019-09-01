using System;

namespace MergeSort
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 10, 22, 32, 11, 19, 9, 10, 22 };
            var sorter = new MergeSortUtil(numbers);
            var result = sorter.Sort();
            for (int i = 0; i < result.Length; i++)
            {
                Console.Write(result[i] + " ");
            }
            Console.Read();
        }
    }
}
