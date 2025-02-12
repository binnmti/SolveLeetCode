namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class PermutationInStringTest
{
    [TestMethod]
    public void PermutationInString()
    {
        Assert.AreEqual(CheckInclusion("abc", "lecabee"), true);
    }

    // Time complexity: O(n log n)
    // Space complexity: O(1)
    public bool CheckInclusion(string s1, string s2)
    {
        var s1sort = string.Concat(s1.OrderBy(x => x).ToArray());
        for (int i = 0; i < s2.Length - s1.Length + 1; i++)
        {
            var s2sort = string.Concat(s2.Substring(i, s1.Length).OrderBy(x => x).ToArray());
            if (s1sort == s2sort)
            {
                return true;
            }
        }
        return false;
    }
}

