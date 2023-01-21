namespace Coding.PerWeek.Challenge.Challenges._2023.January
{
    public class MajorityElement
    {
        /// <summary>
        /// Given an array nums of size n, return the majority element.
        /// The majority element is the element that appears more than ⌊n / 2⌋ times.You may assume that the majority element always exists in the array.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public int MajorityElementSolution(int[] nums)
        {

            var dic = new Dictionary<int,int>();

            var length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                var val = nums[i];
                var addSuccess = dic.TryAdd(val,1);
                if (!addSuccess)
                {
                    dic[val] = dic[val] + 1;
                }                
            }
            
            return dic.MaxBy(kvp => kvp.Value).Key;

        }
    }
}
