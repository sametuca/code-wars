using System;

namespace CodeWars.IQTest
{
    /*

      Bob is preparing to pass IQ test. The most frequent task in this test is to find out which one of the given numbers differs from the others.
      Bob observed that one number usually differs from the others in evenness. Help Bob — to check his answers,
      he needs a program that among the given numbers finds one that is different in evenness, and return a position of this number.
      Keep in mind that your task is to help Bob solve a real IQ test, which means indexes of the elements start from 1 (not 0)
        
        Examples:
        IQ.Test("2 4 7 8 10") => 3 // Third number is odd, while the rest of the numbers are even
    I   Q.Test("1 2 1 1") => 2 // Second number is even, while the rest of the numbers are odd

     */
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(Test("2 2 1 2"));
            Console.ReadLine();
        }
        public static int Test(string numbers)
        {
            int cift = 0, tek = 0, tekSayi = 0, ciftSayi = 0;

            var split = numbers.Split(' ');
            var arr = new int[split.Length];
            for (var i = 0; i < split.Length; i++)
            {
                arr[i] = Convert.ToInt32(split[i]);
                if (arr[i] % 2 == 0)
                {
                    cift++;
                    ciftSayi = arr[i];

                }
                else
                {
                    tek++;
                    tekSayi = arr[i];
                }
            }

            if (tek > cift)
            {
                return ciftSayi;
            }

            var res = Array.IndexOf(arr, tekSayi) + 1;
            return res;
        }
    }
}


