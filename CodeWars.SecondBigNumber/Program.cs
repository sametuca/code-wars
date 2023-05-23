namespace CodeWars.SecondBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var result = SecondBigNumberDeclerative(new int[] { 1, 2, 3, 4, 5, 6, 7, 8, 9, 10,11 });
            Console.WriteLine(result);
        }

        public static int SecondBigNumberImperative(int[] array)
        {
            int maxNumber = int.MinValue;
            int secondMaxNumber = int.MinValue;

            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] > maxNumber)
                {
                    secondMaxNumber = maxNumber;
                    maxNumber = array[i];
                }
                else if (array[i] > secondMaxNumber && array[i] < maxNumber)
                {
                    secondMaxNumber = array[i];
                }
            }

            return secondMaxNumber;
        }
        public static int SecondBigNumberDeclerative(int[] array)
        {
            return array.ToList().OrderByDescending(x => x).
                Skip(1).First();
        }

    }
}