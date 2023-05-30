namespace CodeWars.AlphabetSymmetry
{
    /*
        Consider the word "abode". We can see that the letter a is in position 1 and b is in position 2. In the alphabet, a and b are also in positions 1 and 2. Notice also that d and e in abode occupy the positions they would occupy in the alphabet, which are positions 4 and 5.
        Given an array of words, return an array of the number of letters that occupy their positions in the alphabet for each word. For example,
        solve(["abode","ABc","xyzD"]) = [4, 3, 1]
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            Solve(new List<string> { "abode", "ABc", "xyzD" });
            Console.WriteLine("Hello, World!");
        }

      
        static List<int> Solve(List<string> arr)
    {
        char[] alphabetArray = new char[26];

        for (int i = 0; i < 26; i++)
        {
            alphabetArray[i] = (char)(i + 97);
        }

        var alphabetList = alphabetArray.Select(c => c.ToString()).ToList();
        int count = 0;
        List<int> CountList = new();
        foreach (var item in arr)
        {
            for (int i = 0; i < item.Length; i++)
            {
                if (alphabetList[i] == item[i].ToString().ToLower())
                {
                    count++;
                }
            }
            CountList.Add(count);
            count = 0;
        }

        return CountList;
    }
}
}