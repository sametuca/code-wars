using System;
using System.Collections.Generic;
using System.Linq;

namespace CodeWars.ValidBraces
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello World!");
            string sam = "1234";
            var charSam = sam.ToCharArray();
            charSam[0] = '(';
        }
        public bool ValidBraces(string braces)
        {
            var stack = new Stack<char>();
            foreach (var brace in braces)
            {
                if (brace == '(' || brace == '[' || brace == '{')
                {
                    stack.Push(brace);
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        return false;
                    }
                    if (brace == ')' && stack.Peek() != '(')
                    {
                        return false;
                    }
                    if (brace == ']' && stack.Peek() != '[')
                    {
                        return false;
                    }
                    if (brace == '}' && stack.Peek() != '{')
                    {
                        return false;
                    }
                    stack.Pop();
                }
            }
            return stack.Count == 0;
        }
        // bir başka algoritma
        public static bool validBraces(String braces)
        {
            var current = "";
            while (braces.Any() && current != braces)
            {
                current = braces;
                braces = braces.Replace("()", "").Replace("[]", "").Replace("{}", "");
            }
            return !braces.Any();
        }
    }

}

