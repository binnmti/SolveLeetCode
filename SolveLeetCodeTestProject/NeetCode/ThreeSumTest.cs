namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class ThreeSumTest
{
    [TestMethod]
    public void ThreeSum()
    {
        Array.ReferenceEquals(ThreeSum([-1, 0, 1, 2, -1, -4]), new List<List<int>>() { new() { 1, 1, 2 }, new() { -1, 0, 1 } });
        //ReferenceEquals(ThreeSum([0, 0, 0, 0]), new List<List<int>>() { new() { 0, 0, 0 } });
        //ReferenceEquals(ThreeSum([1, 1, 1]), new List<List<int>>());
        //ReferenceEquals(ThreeSum([-2, 0, 1, 1, 2]), new List<List<int>>() { new() { -2, 0, 2 }, new() { -2, 1, 1 } });
    }

    //Time complexity O(n^2)
    //Space complexity O(n)
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        var listlist = new List<List<int>>();
        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0) break;
            if (i > 0 && nums[i] == nums[i - 1]) continue;

            var left = i + 1;
            var right = nums.Length - 1;
            while (left < right)
            {
                var sum = nums[i] + nums[left] + nums[right];
                if (sum == 0)
                {
                    var list = new List<int>
                    {
                        nums[i], nums[left], nums[right]
                    };
                    listlist.Add(list);

                    left++;
                    while (left < right && nums[left] == nums[left - 1])
                    {
                        left++;
                    }
                }
                else if (sum > 0) right--;
                else left++;
            }
        }
        return listlist;
    }
}

