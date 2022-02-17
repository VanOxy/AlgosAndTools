﻿using System;
using System.Collections.Generic;
using System.Linq;

namespace ConsoleApp1
{
    internal class ArrayMixBySliceReverse
    {
        // C# 8 Syntax
        public List<int> performOperations2(List<int> arr, List<List<int>> operations)
        {
            // arr = new() { 5, 3, 2, 1, 3 };
            // operations = new() { new() { 0, 1 }, new() { 1, 3 } };

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

            return arr;
        }

        public List<int> performOperations(List<int> arr, List<List<int>> operations)
        {
            // arr = new() { 5, 3, 2, 1, 3 };
            // operations = new() { new() { 0, 1 }, new() { 1, 3 } };

            List<int> segment;

            foreach (var idxTuple in operations)
            {
                segment = arr.GetRange(idxTuple[0], idxTuple[1] - idxTuple[0] + 1);
                segment.Reverse();

                segment.AddRange(arr.GetRange(idxTuple[1] + 1, arr.Count - idxTuple[1] - 1));
                arr = segment;
            }

            return arr;
        }
    }
}