namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class LongestRepeatingCharacterReplacementTest
{
    [TestMethod]
    public void LongestRepeatingCharacterReplacement()
    {
        Assert.AreEqual(CharacterReplacement("XYYX", 2), 4);
    }

    //Time complexity O(n)
    //Space complexity O(n)
    public int CharacterReplacement(string s, int k)
    {
        int result = 0;
        for (int i = 0; i < s.Length; i++)
        {
            int max = 0;
            var dic = new Dictionary<char, int>();
            for (int j = i; j < s.Length; j++)
            {
                var key = s[j];
                int co = dic.ContainsKey(key) ? dic[key] + 1 : 1;
                dic[key] = co;
                max = Math.Max(co, max);
                if ((j - i + 1) - max <= k)
                {
                    result = Math.Max(result, j - i + 1);
                }
            }
        }
        return result;
    }
}

