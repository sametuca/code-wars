namespace CodeWars.ContainsDublicate
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var returnBooleanVal = ContainsDuplicate(new int[] { 1, 2, 3, 1 });
            Console.WriteLine(returnBooleanVal);
            Console.ReadKey();
        }
        public static bool ContainsDuplicate(int[] nums)
        {
            return nums.Length != nums.Distinct().Count();
        }
    }
}