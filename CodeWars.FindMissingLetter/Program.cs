using System;
using System.Linq;

namespace CodeWars.FindMissingLetter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
        }
        public static char FindMissingLetter(char[] array)
        {
            var alphabet = char.IsUpper(array.First()) ? "ABCDEFGHIJKLMNOPQRSTUVWXYZ".ToList() : "abcdefghijklmnopqrstuvwxyz".ToList();
            var indexSearch = alphabet.IndexOf(array.First());

            for (int i = 0; i < alphabet.Count; i++)
            {
                if (array[i] != alphabet[indexSearch])
                    return alphabet[indexSearch];

                indexSearch++;
            }

            return ' ';

        }
    }
}
