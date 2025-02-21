namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class MinimumWindowSubstringTest
{
    [TestMethod]
    public void MinimumWindowSubstring()
    {
        //Assert.AreEqual(MinWindow("abbbbbcdd", "abcdd"), "abbbbbcdd");
        //Assert.AreEqual(MinWindow("ADOBECODEBANC", "ABC"), "BANC");
        Assert.AreEqual(MinWindow("OUZODYXAZV", "XYZ"), "YXAZ");
    }

    // Time complexity: O(n^3)
    // Space complexity: O(1)
    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length) return "";

        var tDic = new Dictionary<char, int>();
        foreach (var c in t)
        {
            tDic[c] = tDic.ContainsKey(c) ? tDic[c] + 1 : 1;
        }

        // tは短い。sは長い。sから、tを含む塊を取得する。tのSlide Windowsは決まっていそう
        string min = "";
        int l = 0;
        for (int r = 0; r < s.Length; r++)
        {
            var sDic = new Dictionary<char, int>();
            foreach (var c in s[l..(r + 1)])
            {
                sDic[c] = sDic.ContainsKey(c) ? sDic[c] + 1 : 1;
            }

            // ここでlを進め条件チェック
            while(l < r && (!tDic.ContainsKey(s[l]) || sDic[s[l]] > tDic[s[l]]))
            {
                l++;
            }

            sDic.Clear();
            foreach (var c in s[l..(r + 1)])
            {
                sDic[c] = sDic.ContainsKey(c) ? sDic[c] + 1 : 1;
            }

            // ここで条件チェック
            bool error = false;
            foreach (var (k, v) in tDic)
            {
                if (!sDic.ContainsKey(k))
                {
                    error = true;
                    break;
                }
                else
                {
                    if (sDic[k] < v)
                    {
                        error = true;
                        break;
                    }
                }
            }
            if (!error)
            {
                if (min == "" || s[l..(r + 1)].Length < min.Length)
                {
                    min = s[l..(r + 1)];
                }
            }
        }
        return min;
    }

}

