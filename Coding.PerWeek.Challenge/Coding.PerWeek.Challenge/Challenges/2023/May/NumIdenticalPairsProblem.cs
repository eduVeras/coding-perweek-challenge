namespace Coding.PerWeek.Challenge.Challenges._2023.May
{
    public class NumIdenticalPairsProblem
    {
        public int NumIdenticalPairs(int[] nums)
        {
            int total = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                for (int j = i ; j < nums.Length; j++)
                {
                    if(i < j)
                    {
                        if (nums[i] == nums[j])
                        {
                            total++;
                        }
                    }
                    
                }
            }

            return total;
        }
    }
}
