using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.PerWeek.Challenge.Challenges._2023.May
{
    public class FindLuckyProblem
    {
        public int FindLucky(int[] arr)
        {
            var dic = new Dictionary<int, int>();

            for (int i = 0; i < arr.Length; i++)
            {
                var val = arr[i];
                var addSuccess = dic.TryAdd(val, 1);
                if (!addSuccess)
                {
                    dic[val] = dic[val] + 1;
                }
            }

            var result = dic.Where(e => e.Key == e.Value).OrderByDescending(e=> e.Key);
            
            return result.Any() ? result.FirstOrDefault().Key : -1;
        }
    }
}
