using System;
using System.Linq;

namespace CodeWars.WhichAreIn
{
    /*
     Given two arrays of strings a1 and a2 return a sorted array r in lexicographical order of the strings of a1 which are substrings of strings of a2.

Example 1:
a1 = ["arp", "live", "strong"]

a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

returns ["arp", "live", "strong"]

Example 2:
a1 = ["tarp", "mice", "bull"]

a2 = ["lively", "alive", "harp", "sharp", "armstrong"]

returns []

Notes:
Arrays are written in "general" notation. See "Your Test Cases" for examples in your language.
In Shell bash a1 and a2 are strings. The return is a string where words are separated by commas.
Beware: In some languages r must be without duplicates.*/


    class Program
    {
        static void Main(string[] args)
        {

            


            string[] a1 = new string[] { "tarp", "mice", "bull" };
            string[] a2 = new string[] { "lively", "alive", "harp", "sharp", "armstrong" };
            var result = inArray(a1, a2).ToList();
            foreach (var item in result)
            {
                Console.WriteLine(item);
            }
            CheckHowEmpty(new char[] { 'a', 'b', });
            Console.ReadKey();
        }

        static string[] inArray(string[] array1, string[] array2)
        {
            return (from a in array1 from b in array2 where b.Contains(a) select a).Distinct().OrderBy(e => e).ToArray();
        }

        static char CheckHowEmpty(char[] array)
        {

            char[] alphabetic = { 'a', 'b', 'c', 'd', 'e', 'f', 'g', 'h', 'i', 'j', 'k', 'l', 'm', 'n', 'o', 'p', 'q', 'r', 's', 't', 'u', 'v', 'w', 'x', 'y', 'z' };
            var firstValue = array[0];
            var findinAlpha = alphabetic.Where(x => x == firstValue);
            alphabetic.GetValue(firstValue);
            for (int i = 0; i < alphabetic.Length; i++) 
            {
                if (alphabetic[i].ToString().ToLower() == array[i].ToString().ToLower())
                    return alphabetic[i];
            }
           
            return 'a';
        }
    }
}

