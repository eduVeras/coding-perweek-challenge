using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Coding.PerWeek.Challenge.Challenges._2023.January
{
    internal class RemoveElementProblem
    {
        public int RemoveElement(int[] nums, int val)
        {


            for (int i = 0; i < nums.Length; i++)
            {
                if(nums[i] == val)
                {
                    nums[i] = 1;
                }
            }

            return 1;
        }
    }
}
