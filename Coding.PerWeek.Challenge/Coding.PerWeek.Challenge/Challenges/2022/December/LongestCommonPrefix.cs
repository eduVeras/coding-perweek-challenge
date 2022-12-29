using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.PerWeek.Challenge.Challenges._2022.December
{
    internal class LongestCommonPrefix
    {
        public string LongestCommonPrefixCase(string[] strs)
        {

            if (strs == null || strs.Length == 0)
            {
                return "";
            }

            string first = strs[0];
            int i = 1;
            while (i < strs.Length)
            {
                while (strs[i].IndexOf(first) != 0)
                    first = first.Substring(0, first.Length - 1);
                i++;
            }
            return first;
        }

    }
}
