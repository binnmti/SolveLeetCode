namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class FindTheDuplicateNumberTest
{
    [TestMethod]
    public void FindTheDuplicateNumber()
    {
        Assert.AreEqual(FindDuplicate([1, 2, 3, 2, 2]), 2);
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public int FindDuplicate(int[] nums)
    {
        var hash = new HashSet<int>();
        foreach (var n in nums)
        {
            if (hash.Contains(n))
            {
                return n;
            }
            hash.Add(n);
        }
        return 0;
    }
}

