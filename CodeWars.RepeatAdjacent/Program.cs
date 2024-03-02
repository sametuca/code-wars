
namespace CodeWars.RepeatAdjacent
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //var harfGruplari = "aabbcc".GroupBy(x => x)
            //                      .Select(x => x.Select(y => y.ToString())).ToArray();

            //RepeatAdjacentList("aabbcc");
            adjents("aaaabbbcc");

            //gl -> 1 -> 2 -> 3 -> 
            //bgc -> 1 

            //gl -> 1 -> 2 -> 3 ->
            //bgc -> 1
        }

        public static int CountBigGroups(string s)
        {
            int bigGroupCount = 0; // Büyük grupların sayısını tutmak için bir sayaç oluşturulur. Başlangıçta 0 olarak ayarlanır.
            int groupLength = 1; // Mevcut karakter grubunun uzunluğunu tutmak için bir değişken oluşturulur. Başlangıçta 1 olarak ayarlanır çünkü her karakter kendi grubunu oluşturur.

            for (int i = 1; i < s.Length; i++) // Dize boyunca her bir karakter için bir döngü oluşturulur. 1'den başlanır çünkü ilk karakterden önce bir önceki karakter yoktur.
            {
                if (s[i - 1] == s[i]) // Mevcut karakter ile bir önceki karakter aynıysa...
                {
                    groupLength++; // Mevcut grup uzunluğu bir artırılır çünkü mevcut karakter mevcut gruba aittir.
                }
                else // Mevcut karakter bir önceki karakterden farklıysa...
                {
                    if (groupLength >= 2) // Eğer mevcut grup 2 veya daha fazla karakter içeriyorsa...
                    {
                        bigGroupCount++; // Büyük grup sayacı artırılır çünkü mevcut grup bir büyük gruptur.
                    }
                    groupLength = 1; // Grup uzunluğu sıfırlanır çünkü yeni bir grup başlamıştır ve mevcut karakter grup içindeki ilk karakterdir.
                }
            }

            // Son grup tamamlanmış olabilir, bu yüzden son olarak kontrol edilir.
            if (groupLength >= 2) // Eğer son grup 2 veya daha fazla karakter içeriyorsa...
            {
                bigGroupCount++; // Büyük grup sayacı bir artırılır çünkü son grup bir büyük gruptur.
            }

            return bigGroupCount; // Son olarak, bulunan büyük grup sayısı döndürülür.
        }


        //aaabbbbccccc
        static int adjents(string input)
        {
            List<string[]> baseList = new List<string[]>();
            List<string> currList = new List<string> { input[0].ToString() };
            for (int i = 1; i < input.Length; i++)
            {
                if (input[i - 1] == input[i])
                {
                    currList.Add(input[i].ToString());
                }
                else
                {
                    baseList.Add(currList.ToArray());
                    currList.Clear();
                    currList.Add(input[i].ToString());
                }
            }
            baseList.Add(currList.ToArray());

            List<string> childArr = new List<string>();
            for (int i = 1; i <= 2; i++)
            {
                //childArr.Add();
            }
            return 0;
        }

        //static List<string[]> RepeatAdjacentList(string input)
        //{

        //    List<string[]> baseList = new List<string[]>();
        //    string[] tempGroup = new string[1] { input[0].ToString() };
        //    for (int i = 1; i < input.Length; i++)
        //    {
        //        if (input[i] == input[i - 1])
        //        {
        //            tempGroup[0] += input[i];
        //        }
        //        else
        //        {
        //            baseList.Add(tempGroup);
        //            tempGroup = new string[1] { input[i].ToString() };
        //        }
        //    }
        //    baseList.Add(tempGroup);
        //    return baseList;
        //}
    }

}
