namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class PermutationInStringTest
{
    [TestMethod]
    public void PermutationInString()
    {
        Assert.AreEqual(CheckInclusion("adc", "dcda"), true);
        Assert.AreEqual(CheckInclusion("abc", "lecabee"), true);
    }

    // Time complexity: O(n + m)
    // Space complexity: O(1)
    public bool CheckInclusion(string s1, string s2)
    {
        var dic1 = new Dictionary<char, int>();
        foreach (var c1 in s1)
        {
            dic1[c1] = dic1.TryGetValue(c1, out int value) ? value + 1 : 1;
        }
        for (int i = 0; i <= s2.Length - s1.Length; i++)
        {
            var dic2 = new Dictionary<char, int>();
            foreach (var c2 in s2.Substring(i, s1.Length))
            {
                dic2[c2] = dic2.TryGetValue(c2, out int value) ? value + 1 : 1;
            }
            if (!dic1.Any(x => !dic2.TryGetValue(x.Key, out int value) || x.Value != value)) return true;
        }
        return false;
    }
}

