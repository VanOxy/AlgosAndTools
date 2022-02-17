using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgosAndTools
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            List<int> arr = new() { 5, 3, 2, 1, 3 };
            List<List<int>> operations = new() { new() { 0, 1 }, new() { 1, 3 } };

            Console.WriteLine(string.Join("", arr));

            foreach (var idxTuple in operations)
            {
                List<int> segment = new();

                int startIdx = idxTuple[0];
                int endIdx = ++idxTuple[1]; // ++ so that, we can grab values at both indices

                Range r0 = ..startIdx;
                Range r1 = startIdx..endIdx;
                Range r2 = endIdx..;

                var slicePre = arr.ToArray()[r0];
                var sliceMidReversed = arr.ToArray()[r1].Reverse();
                var slicePost = arr.ToArray()[r2];

                segment.AddRange(slicePre);
                segment.AddRange(sliceMidReversed);
                segment.AddRange(slicePost);

                arr = segment;
                Console.WriteLine(string.Join("", arr));
            }
        }

        public static int toolchanger(List<string> tools, int startIndex, string target)
        {
            int targetIndex = tools.FindIndex(x => x.StartsWith(target));
            int distanceOne = Math.Abs(startIndex - targetIndex);
            int distanceTwo = Math.Abs(tools.Count - targetIndex + startIndex);

            return distanceOne < distanceTwo ? distanceOne : distanceTwo;
        }
    }
}