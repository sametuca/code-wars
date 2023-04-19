using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.SortArrayStringLength
{
    internal class Program
    {
        static void Main(string[] args)
        {

            string[] arr2 = { "Beg", "Life", "I", "To" };
            var getValue = ShortString(arr2);
        }
        public static string[] ShortString(string[] array)
        {
            // solution 1 ->
            return array.OrderBy(e => e.Length).ToArray();

            // solution 2 ->
            //List<string> list = new();
            //if (arr2 == null)
            //    return null;
            //foreach (string s in arr2)
            //{
            //    list.Add(s);
            //}
            //return list.OrderBy(x => x.Length).ToList().ToArray();
        }
    }
}
