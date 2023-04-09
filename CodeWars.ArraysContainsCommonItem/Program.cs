using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.ArraysContainsCommonItem
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
    }
    //Given 2 Arrays, Return True if arrays contain common item, else false.
    //e.g a= ['a','b','g','c'] and b =['z','e','c'] returns true
    //input : 2 arrays
    //output: bool

    public class Kata
    {
        public static bool ContainsCommonItem(char[] a, char[] b)
        { //not mine
            for (int i = 0; i < a.Length; i++)
                for (int j = 0; j < b.Length; j++)
                    if (a[i] == b[j])
                        return true;
            return false;
        }
        public static bool ContainsCommonItemBetter(char[] a, char[] b)
        { //not min

            HashSet<char> items = new HashSet<char>();

            foreach (char item in a)
                items.Add(item);
            for (int i = 0; i < b.Length; i++)
                if (items.Contains(b[i]))
                    return true;
            return false;
        }
        public static bool ContainsCommonItemMoreSimple(char[] a, char[] b) // mine
        {
            var charsExcistingInBoth = a.Intersect(b);
            return charsExcistingInBoth.Count() > 0 ? true : false;
        }

        public static bool ContainsCommonItemUsingAny(char[] a, char[] b)
        {
            return a.Any(ch => b.Contains(ch));
        }

        public static bool ContainsCommonItemUsingAnySimplified(char[] a, char[] b)
        {
            return a.Any(b.Contains);
        }

    }
}

