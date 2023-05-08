using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.PerWeek.Challenge.Challenges._2023.April
{
    public class CountBallsProblem
    {
        public int CountBalls(int lowLimit, int highLimit)
        {

            var dic = new Dictionary<int, int>();
            for (int i = lowLimit; i < highLimit +1; i++)
            {
                var charArray = i.ToString().ToCharArray();
                
                int result = 0;
                foreach(var num in charArray)
                {
                    result += Convert.ToInt32(num.ToString());
                }

                var addSuccess = dic.TryAdd(result, 1);
                if (!addSuccess)
                {
                    dic[result] = dic[result] + 1;
                }

            }
            return dic.MaxBy(kvp => kvp.Value).Value;
        }
    }



}
