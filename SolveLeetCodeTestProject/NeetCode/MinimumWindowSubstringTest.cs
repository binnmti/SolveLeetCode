namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class MinimumWindowSubstringTest
{
    [TestMethod]
    public void MinimumWindowSubstring()
    {
        Assert.AreEqual(MinWindow("abbbbbcdd", "abcdd"), "abbbbbcdd");
        //Assert.AreEqual(MinWindow("ADOBECODEBANC", "ABC"), "BANC");
    }

    // Time complexity: O(n^3)
    // Space complexity: O(1)
    public string MinWindow(string s, string t)
    {
        if (s.Length < t.Length) return "";
        // tは短い。sは長い。sから、tを含む塊を取得する。tのSlide Windowsは決まっていそう
        string min = "";
        for (int l = 0; l < s.Length; l++)
        {
            for (int r = l; r < s.Length; r++)
            {
                var s_sub = s[l..(r+1)];
                // t と s_subで tが全部含まれていればOK。
                if (IsEqual(s_sub, t))
                {
                    if (min == "" || min.Length > s_sub.Length)
                    {
                        min = s_sub;
                    }
                }
            }
        }
        return min;
    }

    private bool IsEqual(string sSub, string t)
    {
        var sDic = new Dictionary<char, int>();
        var tDic = new Dictionary<char, int>();
        foreach (var c in t)
        {
            tDic[c] = tDic.ContainsKey(c) ? tDic[c] + 1 : 1;
        }
        foreach (var c in sSub)
        {
            sDic[c] = sDic.ContainsKey(c) ? sDic[c] + 1 : 1;
        }

        foreach (var (k, v) in tDic)
        {
            if (!sDic.ContainsKey(k))
            {
                return false;
            }
            else
            {
                if (sDic[k] < v)
                {
                    return false;
                }
            }
        }
        return true;
    }
}

