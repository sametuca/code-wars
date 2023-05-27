namespace CodeWars.ProductOfLargestPair
{
    internal class Program
    {
        /*
        Rick wants a faster way to get the product of the largest pair in an array. Your task is to create a performant solution to find the product of the largest two integers in a unique array of positive numbers.
        All inputs will be valid.
        Passing [2, 6, 3] should return 18, the product of [6, 3].
         */
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var result = MaxProduct2(new int[] {1,2,3,4,5});
            Console.WriteLine(result);
        }
        static int MaxProduct(int[] array)
        {
            var index = 0;
            var firstNumber = 0;
            var secondNumber = 0;
            int[] secondArray = new int[array.Length - 1];
            for (int i = 0; i < array.Length; i++)
            {
                if (firstNumber < array[i])
                {
                    firstNumber = array[i];
                }
            }
            for (int i = 0; i < array.Length; i++)
            {
                if (array[i] != firstNumber)
                {
                    secondArray[index] = array[i];
                    index++;
                }
            }
            foreach (int value in secondArray)
            {
                if (secondNumber < value)
                {
                    secondNumber = value;
                }
            }
            return firstNumber * secondNumber;
        }

        static int MaxProduct2(int[] array)
        {
            List<int> arr = array.ToList();
            var firstBigNumber = arr.Max();
            arr.Remove(firstBigNumber);
            var secondBigNumber = arr.Max();
            return firstBigNumber * secondBigNumber;
        }

    }
}