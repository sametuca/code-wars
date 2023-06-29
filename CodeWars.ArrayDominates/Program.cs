namespace CodeWars.ArrayDominates
{
    /**
     * 
     * DESCRIPTION:
        A zero-indexed array arr consisting of n integers is given. The dominator of array arr is the value that occurs in more than half of the elements of arr.
        For example, consider array arr such that arr = [3,4,3,2,3,1,3,3]
        The dominator of arr is 3 because it occurs in 5 out of 8 elements of arr and 5 is more than a half of 8.
        Write a function dominator(arr) that, given a zero-indexed array arr consisting of n integers, returns the dominator of arr. The function should return −1 if array does not have a dominator. All values in arr will be >=0.
     * 
     * 
     * */
    internal class Program
    {
        static void Main(string[] args)
        {
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
        // 2. Solution
        public static int WhoDominates2(int[] array)
        {

            var groups = array.GroupBy(a => a);
            if (groups.Max(g => g.Count()) > array.Length / 2)
            {
                return groups.OrderByDescending(g => g.Count()).First().Key;
            }
            return -1;

        }

    }
}