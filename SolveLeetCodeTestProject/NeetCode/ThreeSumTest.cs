namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class ThreeSumTest
{
    [TestMethod]
    public void ThreeSum()
    {
        Assert.IsTrue(ThreeSum([-1, 0, 1, 2, -1, -4]).SequenceEqual(new List<List<int>>() { new() { -1, -1, 2 }, new() { -1, 0, 1 } }));
        //ReferenceEquals(ThreeSum([0, 0, 0, 0]), new List<List<int>>() { new() { 0, 0, 0 } });
        //ReferenceEquals(ThreeSum([1, 1, 1]), new List<List<int>>());
        //ReferenceEquals(ThreeSum([-2, 0, 1, 1, 2]), new List<List<int>>() { new() { -2, 0, 2 }, new() { -2, 1, 1 } });
    }

    //Time complexity O(n^3)
    //Space complexity O(1)
    public List<List<int>> ThreeSum(int[] nums)
    {
        Array.Sort(nums);

        var hashset = new HashSet<(int, int, int)>();
        for (int i = 0; i < nums.Length; i++)
        {
            for (int j = i + 1; j < nums.Length; j++)
            {
                for (int k = j + 1; k < nums.Length; k++)
                {
                    if (nums[i] + nums[j] + nums[k] == 0)
                    {
                        hashset.Add((nums[i], nums[j], nums[k]));
                    }
                }
            }
        }
        var listlist = new List<List<int>>();
        foreach (var value in hashset)
        {
            var list = new List<int>
            {
                value.Item1, value.Item2, value.Item3
            };
            listlist.Add(list);
        }
        return listlist;
    }
}

