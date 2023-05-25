using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.FindTheOddInt
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            find_it2(new[] { 1, 2, 3, 4 });
        }

        public static int find_it(int[] seq)
        {
            // 1 2 3 1 4 5
            // 0 1 2 3 4 5
            int[] seqTwo = new int[seq.Length];
            for (var i = 0; i < seq.Length; i++)
            {
                for (var j = 1; j < seq.Length; j++)
                {
                    if (seq[i] == seq[j])
                    {
                        seqTwo[i] = seq[i];
                    }
                }
            }

            return seqTwo[0];
        }

        public static int find_it2(int[] seq)
        {
            var dictionary = seq.ToArray()
                .Select((i,index) => new {Number=i,Index=index})
                .ToDictionary(x=> x.Index, x=>x.Number);
            return -1;
        }
    }
}
