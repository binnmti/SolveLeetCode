namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
internal class GenerateParenthesesTest
{
    [TestMethod]
    public void GenerateParentheses()
    {
        var ret = GenerateParenthesis(1);
        Assert.AreEqual(ret, ["()"]);
    }

    private static bool Valid(string str)
    {
        int open = 0;
        foreach (var s in str)
        {
            if (s == '(')
            {
                open++;
            }
            else
            {
                open--;
            }
            if (open < 0) return false;
        }
        return open == 0;
    }

    private static void Dfs(string str, List<string> list, int n)
    {
        if (str.Length == 2 * n)
        {
            if (Valid(str))
            {
                list.Add(str);
            }
            return;
        }
        Dfs(str + "(", list, n);
        Dfs(str + ")", list, n);
    }

    // Time complexity O(2^2n * n)
    // Space complexity O(2^2n * n)
    public List<string> GenerateParenthesis(int n)
    {
        var list = new List<string>();
        Dfs("", list, n);
        return list;
    }
}

