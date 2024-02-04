namespace CodeWars.RomanToIntegerConverter
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            RomanToInt("XIV");
        }

        public static int RomanToInt(string romanNumeral)
        {
            Dictionary<char, int> romanValues = new Dictionary<char, int>
        {
            { 'I', 1 },
            { 'V', 5 },
            { 'X', 10 },
            { 'L', 50 },
            { 'C', 100 },
            { 'D', 500 },
            { 'M', 1000 }
        };

            int result = 0;
            int prevValue = 0;

            for (int i = romanNumeral.Length - 1; i >= 0; i--)
            {
                int currentVal = romanValues[romanNumeral[i]];

                if (currentVal < prevValue)
                    result -= currentVal;
                else
                    result += currentVal;

                prevValue = currentVal;
            }

            return result;
        }
    }


}
