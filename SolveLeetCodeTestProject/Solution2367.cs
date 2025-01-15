
namespace SolveLeetCodeTestProject
{
    internal class Solution2367
    {
        internal static int ArithmeticTriplets(int[] nums, int diff)
        {
            var map = nums.Select((val, idx) => (val, idx)).ToDictionary(x => x.val, x => x.idx);
            return nums.Count(x => map.ContainsKey(x + diff) && map.ContainsKey(x + diff + diff));
        }
    }
}