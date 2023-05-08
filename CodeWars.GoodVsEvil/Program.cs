namespace CodeWars.GoodVsEvil
{
    internal class Program
    {
        static void Main(string[] args)
        {
            var returnBooleanVal = GoodVsEvil("1 1 1 1 1 1", "1 1 1 1 1 1 1");
            Console.WriteLine(returnBooleanVal);
        }

        public static string GoodVsEvil(string good, string evil)
        {
            int[] goodValues = new int[] { 1, 2, 3, 3, 4, 10 };
            int[] evilValues = new int[] { 1, 2, 2, 2, 3, 5, 10 };
            int goodSum = good.Split(' ').Select((s, i) => int.Parse(s) * goodValues[i]).Sum();
            int evilSum = evil.Split(' ').Select((s, i) => int.Parse(s) * evilValues[i]).Sum();
            if (goodSum > evilSum)
                return "Battle Result: Good triumphs over Evil";
            else if (evilSum > goodSum)
                return "Battle Result: Evil eradicates all trace of Good";
            else
                return "Battle Result: No victor on this battle field";
        }
    }
}