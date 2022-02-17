using System;
using System.Collections.Generic;

namespace AlgosAndTools
{
    internal class PosNegNumbersRatio
    {
        private void Run(List<int> arr)
        {
            //List<int> arr = new() { -2, -5, 0, 4, 8 };

            if (arr.Count > 100) throw new Exception("Max length exceeded");
            if (arr == null || arr.Count == 0) throw new Exception("Can't be null or nothing");

            double positifRt = 0, negatifRt = 0, zeroRt = 0;

            foreach (int item in arr)
            {
                if (item < -100 || item > 100) throw new Exception("Numbers out of range");

                if (item < 0) negatifRt++;
                if (item > 0) positifRt++;
                if (item == 0) zeroRt++;
            }

            Console.WriteLine(String.Format("{0:F6}", positifRt / arr.Count));
            Console.WriteLine(String.Format("{0:F6}", negatifRt / arr.Count));
            Console.WriteLine($"{ zeroRt / arr.Count}:F6");
        }
    }
}