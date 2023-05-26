using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.FindTheOddInt
{
    class Program
    {
        /*
        Given an array of integers, find the one that appears an odd number of times.

        There will always be only one integer that appears an odd number of times.

        Examples
        [7] should return 7, because it occurs 1 time (which is odd).
        [0] should return 0, because it occurs 1 time (which is odd).
        [1,1,2] should return 2, because it occurs 1 time (which is odd).
        [0,1,0,1,0] should return 0, because it occurs 3 times (which is odd).
        [1,2,2,3,3,3,4,3,3,3,2,2,1] should return 4, because it appears 1 time (which is odd).
         
         */
        static void Main(string[] args)
        {
            var result = FindDuplicate(new[] { 1, 2, 3, 4, 1, 2 });
            Console.WriteLine(result);
        }

        //alternative
        public static int find_it(int[] seq)
        {
            return seq.Aggregate(0, (a, b) => a ^ b);
        }

        public static int FindDuplicate(int[] nums)
        {
            HashSet<int> hash = new HashSet<int>();
            foreach (int num in nums)
            {
                if (hash.Contains(num) && num % 2 == 1)
                {
                    return num;
                }
                else
                {
                    hash.Add(num);
                }
            }
            return -1;
        }
    }
}
