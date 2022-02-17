using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgosAndTools
{
    internal class MatrixDiagonalesSumDifference
    {
        public static int diagonalDifference(List<List<int>> arr)
        {
            /* 11  2   4        | 11 + 5 - 12
                4  5   6        |  4 + 5 + 10
               10  8 -12 */

            List<int> lineOne = new List<int>();
            List<int> lineTwo = new List<int>();

            for (int i = 0; i < arr.Count; i++)
            {
                var line = arr.ElementAt(i);
                lineOne.Add(line.ElementAt(i));
                lineTwo.Add(line.ElementAt(line.Count - i - 1));
            }

            int sumOne = 0, sumTwo = 0;

            foreach (var item in lineOne)
                sumOne += item;
            foreach (var item in lineTwo)
                sumTwo += item;

            int abs = Math.Abs(sumTwo - sumOne);
            return abs;
        }
    }
}