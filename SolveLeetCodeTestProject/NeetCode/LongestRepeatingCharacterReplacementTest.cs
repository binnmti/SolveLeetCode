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
        var dic = new Dictionary<char, int>();
        int l = 0;
        int max = 0;
        int result = 0;
        for (int r = 0; r < s.Length; r++)
        {
            var key = s[r];
            dic[key] = dic.ContainsKey(key) ? dic[key] + 1 : 1;
            max = Math.Max(dic[key], max);

            while ((r - l + 1) - max > k)
            {
                dic[s[l]]--;
                l++;
            }
            result = Math.Max(result, r - l + 1);
        }
        return result;
    }
}

