namespace CodeWars.Required_Data_I
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");
            var result = CountSelFirstSolution(new int[] { -3, -2, -1, 3, 4, -5, -5, 5, -1, -5 });
        }

        public static object[] CountSelFirstSolution(int[] lst)
        {
            var total = lst.Count();

            var lstGroupBy = lst.GroupBy(x => x)
                             .Select(num => new { Number = num.Key, Count = num.Count() })
                             .OrderByDescending(x => x.Count);

            var different = lstGroupBy.Count();

            var onlyOnce = lstGroupBy.Where(x => x.Count == 1).Count();

            var maxOccurence = lstGroupBy.First().Count;

            var maxOccuranceNumbersArray = lstGroupBy.Where(x => x.Count == maxOccurence);

            var maxOccuranceNumbers = maxOccuranceNumbersArray.Select(x => x.Number).OrderBy(x => x).ToArray();

            return new object[] { total, different, onlyOnce, new object[] { maxOccuranceNumbers, maxOccurence } };
        }

        public static object[] CountSelSecondSolution(int[] lst)
        {
            var lstCount = lst.Length; // 10
            var totalDiffrentValue = lst.ToArray().Distinct().Count(); // 7
            var diffrent = lst.ToArray().GroupBy(x=>x).Where(x=>x.Count()==1).Select(x=>x.Key).Count(); // 5
            var maxDiffrent = lst.ToArray().GroupBy(x => x).Select(x => x.Count()).Max(); //3
            var maxDiffrentValue = lst.GroupBy(x => x).Where(x => x.Count() == maxDiffrent).Select(x => x.Key).First(); //-5
            var resultList = new object[]
            {
                lstCount,
                totalDiffrentValue,
                diffrent,
                maxDiffrent,
                new object[]
                {
                    maxDiffrent,
                    maxDiffrentValue
                }
            };

            var total = lst.ToArray().Sum();

            return resultList;
        }
    }
}