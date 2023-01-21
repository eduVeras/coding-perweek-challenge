namespace Coding.PerWeek.Challenge.Challenges._2023.January
{
    public class MajorityElementII
    {
        /// <summary>
        /// Given an integer array of size n, find all elements that appear more than ⌊ n/3 ⌋ times.
        /// </summary>
        /// <param name="nums"></param>
        /// <returns></returns>
        public IList<int> MajorityElement(int[] nums)
        {
            var dic = new Dictionary<int, int>();

            var length = nums.Length;

            for (int i = 0; i < length; i++)
            {
                var val = nums[i];
                var addSuccess = dic.TryAdd(val, 1);
                if (!addSuccess)
                {
                    dic[val] = dic[val] + 1;
                }
            }

            var quantity = length / 3;

            return dic.Where(e=> e.Value > quantity).Select(e=>e.Key).ToList();
        }
    }
}
