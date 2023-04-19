using System;
using System.Linq;

namespace CodeWars.RemoveFirstAndLastCharacter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            var param = "eloquent";
            Console.WriteLine(Remove_char(param));
        }

        public static string Remove_char(string s)
        {
            return s.Remove(s.Length-1,1).Remove(0,1);
        }
    }
}
