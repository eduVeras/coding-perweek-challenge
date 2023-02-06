namespace Coding.PerWeek.Challenge.Challenges._2023.February
{
    public class MostCommonWordProblem
    {
        public string MostCommonWord(string paragraph, string[] banned)
        {
            var compare = paragraph.ToLower().Replace(",", " ").Replace(".", " ").Replace("!"," ").Replace("?"," ").Replace("'"," ").Replace(";"," ").Split(' ');

            var dic = new Dictionary<string, int>();
            for (int i = 0; i < compare.Length; i++)
            {
                
                if (banned.Contains(compare[i].Trim()) || string.IsNullOrWhiteSpace(compare[i].Trim()))
                {
                    continue;
                }

                var addSuccess = dic.TryAdd(compare[i].ToString(), 1);
                if (!addSuccess)
                {
                    dic[compare[i]] = dic[compare[i]] + 1;
                }

            }

            return dic.MaxBy(kvp => kvp.Value).Key;
        }
    }
}
