namespace Coding.PerWeek.Challenge.Challenges._2023.January
{
    internal class FirstUniqCharProblem
    {
        public int FirstUniqChar(string s)
        {

            var dic = new Dictionary<char, Tuple<int,int>>();
            var counting = 0;
            var chars = s.ToCharArray();
            for (int i = 0; i < chars.Length; i++)
            {
                var addSuccess = dic.TryAdd(chars[i], new Tuple<int, int>(1,i));
                if (!addSuccess)
                {
                    dic[chars[i]] = new Tuple<int, int>(dic[chars[i]].Item1 + 1, dic[chars[i]].Item2);
                }
            }

            var result = dic.MinBy(e=> e.Value.Item1).Value;

            return result.Item1 > 1 ? -1 : result.Item2;            

        }
    }
}
