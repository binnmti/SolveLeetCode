namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class ThreeSumTest
{
    [TestMethod]
    public void ThreeSum()
    {
        ReferenceEquals(ThreeSum([-1, 0, 1, 2, -1, -4]), new List<List<int>>() { new() { -1, -1, 2 }, new() { -1, 0, 1 } });
    }

    //Time complexity O(n)
    //Space complexity O(1)
    public List<List<int>> ThreeSum(int[] nums)
    {
        return [];
    }
}

