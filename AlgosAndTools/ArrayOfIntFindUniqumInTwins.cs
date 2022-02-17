using System.Collections.Generic;

namespace ConsoleApp1
{
    internal class ArrayOfIntFindUniqumInTwins
    {
        private int Find(List<int> a)
        {
            List<int> arr = new() { 5, 3, 5, 1, 3 };

            int x = 0;

            foreach (int iter in arr)
            {
                x ^= iter;
            }

            return x;
        }
    }
}