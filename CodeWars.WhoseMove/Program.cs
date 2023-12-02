namespace CodeWars.WhoseMove
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
        }

        public static string WhoseMoveShort(string l, bool w) => w ? l : l == "white" ? "black" : "white";

        public static string WhoseMove(string lastPlayer, bool win)
        {
            if(lastPlayer == "White")
            {
                if(win)
                {
                    return "White";
                }
                else
                {
                    return "Black";
                }
            }
            else
            {
                if(win)
                {
                    return "Black";
                }
                else
                {
                    return "White";
                }
            }
        }
    }
}