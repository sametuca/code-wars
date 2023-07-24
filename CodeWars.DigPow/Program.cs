using System;
using System.Linq;
/*
 Some numbers have funny properties. For example:

89 --> 8¹ + 9² = 89 * 1

695 --> 6² + 9³ + 5⁴= 1390 = 695 * 2

46288 --> 4³ + 6⁴+ 2⁵ + 8⁶ + 8⁷ = 2360688 = 46288 * 51

Given a positive integer n written as abcd... (a, b, c, d... being digits) and a positive integer p

we want to find a positive integer k, if it exists, such that the sum of the digits of n taken to the successive powers of p is equal to k * n.
In other words:

Is there an integer k such as : (a ^ p + b ^ (p+1) + c ^(p+2) + d ^ (p+3) + ...) = n * k

If it is the case we will return k, if not return -1.

Note: n and p will always be given as strictly positive integers.
 */
namespace CodeWars.DigPow
{
    public static class ArrayExtensions
    {
        //only converted int variables
        public static int[] ConvertToIntArray(this int param)
        {
            int paramLenght = param.ToString().Length;
            int[] resultArray = new int[paramLenght];
            for(int i = 0; i < paramLenght; i++)
                resultArray[i] = param.ToString()[i];
            return resultArray;
        }
    }

    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            Console.WriteLine(digPow2(89, 1));
        }
        public static long digPow1(int n, int p)
        {
            var sum = Convert.ToInt64(n.ToString().Select(s => Math.Pow(int.Parse(s.ToString()), p++)).Sum());
            return sum % n == 0 ? sum / n : -1;
        }



        public static long digPow2(int n, int p)
        {
            char[] charArray = n.ToString().ToCharArray();
            //int[] nToIntArray = n.ConvertToIntArray();
            int[] intArray = new int[charArray.Length];
            for (int i = 0; i <= intArray.Length-1; i++)
            {
                intArray[i] = int.Parse(charArray[i].ToString());
            }
            double math = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                math += Math.Pow(intArray[i], i+1);
            }
            return (long)math;
        }

        public static long digPow3(int n, int p)
        {
            char[] digits = n.ToString().ToCharArray();
            long sum = 0;
            for (int i = 0; i < digits.Length; i++)
            {
                sum += (long)Math.Pow(Char.GetNumericValue(digits[i]), p + i);
            }
            long k = sum / n;
            if (sum % n == 0)
            {
                return k;
            }
            else
            {
                return -1;
            }
        }
    }
}
