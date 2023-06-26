namespace CodeWars.ArrayDominates
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            WhoDominates(new int[] { 3, 4, 3, 2, 3, 1, 3, 3 });
        }
        public static int WhoDominates(int[] array)
        {
            Dictionary<int,int> dic = new Dictionary<int,int>();
            for (int i = 0; i < array.Length; i++)
            {
                if (dic.ContainsKey(array[i]))
                    dic[array[i]]++;
                else
                    dic.Add(array[i], 1);    
            }
            KeyValuePair<int, int> maxPair = new KeyValuePair<int, int>();
            foreach (KeyValuePair<int, int> pair in dic)
            {
                if (pair.Value > maxPair.Value)
                {
                    maxPair = pair;
                }
            }
            if(maxPair.Value > (array.Length / 2))
            {
                return maxPair.Key;
            }
            else
            {
                return -1;
            }

        }
    }
}