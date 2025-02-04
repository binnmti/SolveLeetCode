namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class LongestSubstringWithoutRepeatingCharactersTest
{
    [TestMethod]
    public void LongestSubstringWithoutRepeatingCharacters()
    {
        Assert.AreEqual(LengthOfLongestSubstring("zxyzxyz"), 3);
    }

    //Time complexity O(n)
    //Space complexity O(n)
    public int LengthOfLongestSubstring(string s)
    {
        int l = 0;
        var hs = new HashSet<char>();
        int max = 0;
        for (int r = 0; r < s.Length; r++)
        {
            while (hs.Contains(s[r]))
            {
                hs.Remove(s[l]);
                l++;
            }
            hs.Add(s[r]);
            max = Math.Max(max, r - l + 1);
        }
        return max;
    }
}

