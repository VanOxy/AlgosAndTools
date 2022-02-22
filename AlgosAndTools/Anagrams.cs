using System;
using System.Linq;

namespace AlgosAndTools
{
    internal class Anagrams
    {
        private static bool AreAnagrams(string str1, string str2)
        {
            // string str1 = "dusty", str2 = "study";

            if (str1.Length != str2.Length)
                return false;

            var result = string.Concat(str1.OrderBy(x => x)) == string.Concat(str2.OrderBy(x => x)) ? "true" : "false";
            Console.WriteLine(result);
            return bool.Parse(result);
        }
    }
}
