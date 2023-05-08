namespace CodeWars.MovingZerosToTheEnd
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var returnBooleanVal = MoveZeroes(new int[] { 0,1,0, 2, 3, 1 });
            foreach (var item in returnBooleanVal)
            {
                Console.WriteLine(item);
            }
        }

        public static int[] MoveZeroes(int[] arr)
        {
            List<int> ZeroArr = new List<int>();
            for (int i = 0; i < arr.Length; i++)
            {
                if (arr[i] == 0)
                {
                    ZeroArr.Add(arr[i]);
                }
            }

            arr = arr.Where(x => x != 0).ToArray();
            arr = arr.Concat(ZeroArr).ToArray();
            return arr;
        }

        //kısa çözüm
        public static int[] MoveZeroes2(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ToArray();
        }

        //kısa çözüm
        public static int[] MoveZeroes3(int[] arr)
        {
            return arr.Where(x => x != 0).Concat(arr.Where(x => x == 0)).ToArray();
        }

        //kısa çözüm
        public static int[] MoveZeroes4(int[] arr)
        {
            return arr.OrderBy(x => x == 0).ThenBy(x => x).ToArray();
        }
    }
}