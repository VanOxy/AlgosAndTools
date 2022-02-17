using System;
using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class ArraySumMinusMaxMinFound
    {
        private void Run(List<int> arr)
        {
            // !!! invert min/max values
            int min = int.MaxValue, max = int.MinValue;

            Int64 totalSum = 0;

            for (var index = 0; index < arr.Count; index++)
            {
                if (min > arr[index]) // found a new min
                    min = arr[index];
                if (max < arr[index]) // found a new max
                    max = arr[index];

                totalSum += arr[index];
            }
            // remove max and minum in the last from total sum
            Console.WriteLine($"{totalSum - max} {totalSum - min}");
        }
    }
}