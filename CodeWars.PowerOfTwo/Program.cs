using System;

namespace CodeWars.PowerOfTwo
{
    internal class Program
    {
        /*
         Complete the function power_of_two/powerOfTwo (or equivalent, depending on your language) that determines if a given non-negative integer is a power of two. From the corresponding Wikipedia entry:

a power of two is a number of the form 2n where n is an integer, i.e. the result of exponentiation with number two as the base and integer n as the exponent.

You may assume the input is always valid.
        */
        static void Main(string[] args)
        {
        }
        public static bool PowerOfTwo(int n)
        {

            if (n == 0 || n== 1)
            {
                return false;
            }
            if(n % 2 == 0)
            {
                return true;
            }
            return true;
        
        }
    }
}
