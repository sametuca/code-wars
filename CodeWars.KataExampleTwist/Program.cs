namespace CodeWars.KataExampleTwist
{
    using System.Linq;

    class Program
    {
        static void Main(string[] args)
        {
        }
        
        public static string[] Websites
        {
            get
            {
                return Enumerable.Range(0,1000).Select(e => "codewars").ToArray();
            }
        }
    }
}

