namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class LongestSubstringWithoutRepeatingCharactersTest
{
    [TestMethod]
    public void LongestSubstringWithoutRepeatingCharacters()
    {
        Assert.AreEqual(LengthOfLongestSubstring("zxyzxyz"), 3);
    }

    //Time complexity O(n^2 * m)
    //Space complexity O(1)
    public int LengthOfLongestSubstring(string s)
    {
        int max = 0;
        // // 1文字ずつふやしていき、つど同じ文字があるかチェック。
        for (int i = 0; i < s.Length; i++)
        {
            for (int j = 1; j < s.Length; j++)
            {
                if (i + j > s.Length) break;

                var str = s.Substring(i, j);

                bool ng = false;
                var hs = new HashSet<char>();
                foreach (var c in str)
                {
                    if (hs.Contains(c))
                    {
                        ng = true;
                    }
                    hs.Add(c);
                }
                if (!ng)
                {
                    max = Math.Max(max, j);
                }
            }
        }
        return max;
    }
}

