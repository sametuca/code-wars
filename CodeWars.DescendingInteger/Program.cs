using System;
using System.Collections.Generic;

namespace CodeWars.DescendingInteger
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(DescendingOrder(59238));
            Console.ReadLine();
        }

        public static int DescendingOrder(int num)
        {
            var digits = new List<int>();

            for (; num != 0; num /= 10)
                digits.Add(num % 10);

            var arr = digits.ToArray();
            Array.Sort(arr);
            foreach (var integerMember in digits)
            {
                return integerMember;
            }
            return num;
        }
    }
}

