using System;
using System.Linq;

namespace CodeWars.DigPow
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            digPow2(24, 2);
        }

        public static long digPow(int n, int p)
        {
            char[] charArray = n.ToString().ToCharArray();
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

        public static long digPow2(int n, int p)
        {
            char[] charArray = n.ToString().ToCharArray();
            int[] intArray = new int[charArray.Length];
            for (int i = 0; i <= intArray.Length - 1; i++)
            {
                intArray[i] = int.Parse(charArray[i].ToString());
            }
            double math = 0;
            for (int i = 0; i < intArray.Length; i++)
            {
                math += Math.Pow(intArray[i], ++p);
            }
            return (long)math * p;
        }
    }
}
