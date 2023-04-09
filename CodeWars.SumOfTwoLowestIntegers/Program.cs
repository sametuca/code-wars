using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.SumOfTwoLowestIntegers
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            int[] sam = new int[] { 1, 2, 3,5 };
        }
        static int Calculate(int[] paramArr)
        {
            List<int> arr1 = new List<int>();
            List<int> arr2 = new List<int>();
            foreach (var item in paramArr)
            {
                arr1.Add(item);
            }
            var lowestOne = arr1.Min();
            foreach (var item in paramArr)
            {
                if (item != lowestOne)
                    arr2.Add(item);
            }
            var lowestTwo = arr2.Min();
            return lowestOne + lowestTwo;
        }
    }
}

