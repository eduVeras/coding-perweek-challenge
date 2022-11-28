namespace Coding.PerWeek.Challenge.Challenges._2022.November
{
    public class TwoSum
    {
        public static int[] Run(int[] nums, int target)
        {

            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = 0; j < nums.Length; j++)
                {
                    if (j == i)
                    {
                        j++;
                    }
                    if (target == nums[j] + nums[i])
                    {
                        return new int[2] { i, j };
                    }
                }
            }

            return new int[0];

        }

        public int[] BestSolution(int[] nums, int target)
        {

            if (nums == null || nums.Length < 2)
                return new int[2];

            Dictionary<int, int> dic = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                if (dic.ContainsKey(target - nums[i]))
                    return new int[] { i, dic[target - nums[i]] };
                else if (!dic.ContainsKey(nums[i]))
                    dic.Add(nums[i], i);
            }

            return new int[2];
        }
    }
}
