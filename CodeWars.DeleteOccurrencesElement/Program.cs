using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.DeleteOccurrencesElement
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] arr = { 1, 1, 3, 3, 7, 2, 2, 2, 2 };
            var result = DeleteNth(arr, 3);
            Console.WriteLine(result);
            Console.ReadKey();
        }
        
        public static int[] DeleteNth(int[] arr, int x)
        {
            // girdi dizisindeki öğeleri filtreler
            return arr.Where((e, i) => 
                // her öğenin sayısını sayar
                arr.Take(i + 1).Count(x => x == e) <= x
            ).ToArray(); // sonucu int[] türünde bir dizi olarak döndürür
        }


        public static int[] DeleteNth2(int[] arr, int x)
        {
            var result = new List<int>();
            var seen = new HashSet<int>();

            foreach (int item in arr)
            {
                if (seen.Count(i => i == item) < x)
                {
                    result.Add(item);
                    seen.Add(item);
                }
            }

            return result.ToArray();
            return arr.GroupBy(e => e).SelectMany(e => e.Take(x)).ToArray();
        }
    }
}

