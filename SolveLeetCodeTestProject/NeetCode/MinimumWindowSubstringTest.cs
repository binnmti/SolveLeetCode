namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class MinimumWindowSubstringTest
{
    [TestMethod]
    public void MinimumWindowSubstring()
    {
        Assert.AreEqual(MinWindow("abbbbbcdd", "abcdd"), "abbbbbcdd");
        Assert.AreEqual(MinWindow("ADOBECODEBANC", "ABC"), "BANC");
        Assert.AreEqual(MinWindow("OUZODYXAZV", "XYZ"), "YXAZ");
    }

    // Time complexity: O(n^2)
    // Space complexity: O(1)
    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length) return "";
        var tDic = t.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        // tは短い。sは長い。sから、tを含む塊を取得する。tのSlide Windowsは決まっていそう
        string min = "";
        int l = 0;
        for (int r = 0; r < s.Length; r++)
        {
            var sDic = s[l..(r + 1)].GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            while (l < r && (!tDic.ContainsKey(s[l]) || sDic[s[l]] > tDic[s[l]]))
            {
                l++;
            }
            if (tDic.Any(x => !sDic.ContainsKey(x.Key) || sDic[x.Key] < x.Value))
            {
                continue;
            }
            if (min == "" || s[l..(r + 1)].Length < min.Length)
            {
                min = s[l..(r + 1)];
            }
        }
        return min;
    }

}

