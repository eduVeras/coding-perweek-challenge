namespace Coding.PerWeek.Challenge.Challenges._2023.March
{
    public class SmallerNumbersThanCurrentProblem
    {
        public int[] SmallerNumbersThanCurrent(int[] nums)
        {
            var awnser = new int[nums.Length];

            for (int i = 0; i < nums.Length; i++)
            {
                int k = 0;
                for (int j = 0; j < nums.Length; j++)
                {
                    if (nums[j] < nums[i])
                    {
                        k++;
                        continue;
                    }

                    break;
                }

                awnser[i] = k;
            }

            return awnser;

        }
    }
}
