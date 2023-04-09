using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CodeWars.ArrayDiff
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(ArrayDiff(new[] { 1, 2 }, new[] { 1 }));

            Console.ReadLine();
        }
        public static int[] ArrayDiff(int[] a, int[] b)
        {
            int[] arr = new int[a.Length];
            for (int i = 0; i < b.Length; i++)
            {
                if (a[i] == b[i])
                {
                    Array.Clear(a, i, i);
                }
            }
            // Your brilliant solution goes here
            // It's possible to pass random tests in about a second ;)
            return a;
        }
    }

}