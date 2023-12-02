using System.Diagnostics.Tracing;

namespace CodeWars.ValidateHello
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var result = Validate_hello("Hallo,");
        }

        public static bool Validate_hello(string greetings)
        {
            var hello = new string[] { "hello", "ciao", "salut", "hallo", "hola", "ahoj", "czesc" };
            var result = hello.Any(x => greetings.ToLower().Contains(x));
            return result;
        }
    }
}