
namespace SolveLeetCodeTestProject
{
    internal class Solution2367
    {
        internal static int ArithmeticTriplets(int[] nums, int diff)
        {
            var map = nums.Select((val, idx) => (val, idx)).ToDictionary(x => x.val, x => x.idx);
            return nums.Count(x => map.ContainsKey(x + diff) && map.ContainsKey(x + diff + diff));

            //var map = new Dictionary<int, int>();
            //for (int i = 0; i < nums.Length; i++)
            //{
            //    map[nums[i]] = i;
            //}
            var hit = 0;
            for (int i = 0; i < nums.Length; i++)
            {
                if (map.ContainsKey(nums[i] + diff) && map.ContainsKey(nums[i] + diff + diff))
                {
                    hit++;
                }
            }
            return hit;
        }
    }
}