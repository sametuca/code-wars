using System;
using System.Linq;

namespace CodeWars.FindMissingLetter
{
    internal class Program
    {
        /*
         Find the missing letter
Write a method that takes an array of consecutive (increasing) letters as input and that returns the missing letter in the array.

You will always get an valid array. And it will be always exactly one letter be missing. The length of the array will always be at least 2.
The array will always contain letters in only one case.

Example:

['a','b','c','d','f'] -> 'e'
['O','Q','R','S'] -> 'P'
(Use the English alphabet with 26 letters!)

Have fun coding it and please don't forget to vote and rank this kata! :-)

I have also created other katas. Take a look if you enjoyed this kata!*/
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
