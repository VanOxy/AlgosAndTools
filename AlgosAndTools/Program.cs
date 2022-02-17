using System;
using System.Collections.Generic;
using System.Linq;

namespace AlgosAndTools
{
    internal class Program
    {
        private static void Main(string[] args)
        {
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