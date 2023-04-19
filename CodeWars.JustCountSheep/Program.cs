using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.JustCountSheep
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var returnValue = CountSheep(3);
            Console.WriteLine(returnValue);
            Console.ReadLine();
        }
        public static string CountSheep(int n)
        {

            return string.Concat(Enumerable.Range(1, n).Select(i => i + " sheep..."));

            //List<string> list = new List<string>();
            //if (n == 1) {
            //    return "1 sheep...";
            //}
            //for (int i = 0; i < n; i++)
            //{
            //    list.Add($"{i+1} sheep...");
            //}
            //string joinedString = string.Join("", list);
            //return joinedString;
        }
    }
}
