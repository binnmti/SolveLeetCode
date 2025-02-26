namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class MinimumWindowSubstringTest
{
    [TestMethod]
    public void MinimumWindowSubstring()
    {
        Assert.AreEqual(MinWindow("aaaaaaaaaaaabbbbbcdd", "abcdd"), "abbbbbcdd");
        Assert.AreEqual(MinWindow("ADOBECODEBANC", "ABC"), "BANC");
        Assert.AreEqual(MinWindow("OUZODYXAZV", "XYZ"), "YXAZ");
    }

    // Time complexity: O(n^2)
    // Space complexity: O(1)
    public string MinWindow(string s, string t)
    {
        var tDic = t.GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());

        // tは短い。sは長い。sから、tを含む塊を取得する。tのSlide Windowsは決まっていそう
        string min = "";
        int l = 0;
        int hit = 0;
        for (int r = 0; r < s.Length; r++)
        {
            var sDic = s[l..(r + 1)].GroupBy(x => x).ToDictionary(x => x.Key, x => x.Count());
            var rKey = s[r];
            if (tDic.ContainsKey(rKey) && sDic[rKey] == tDic[rKey])
            {
                hit++;
            }
            while (tDic.Count == hit)
            {
                if (min == "" || min.Length > s[l..(r + 1)].Length)
                {
                    min = s[l..(r + 1)];
                }

                var lKey = s[l];
                if (tDic.ContainsKey(lKey))
                {
                    if (sDic[lKey] == tDic[lKey])
                    {
                        hit--;
                    }
                    else
                    {
                        sDic[lKey]--;
                    }
                }
                l++;
            }
        }
        return min;
    }

}

