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

    private static void Dfs(int open, int close, int n, List<string> parentheses, string s)
    {
        if (open == close && open == n)
        {
            parentheses.Add(s);
            return;
        }
        if (open < n)
        {
            Dfs(open + 1, close, n, parentheses, s + "(");
        }
        if (open > close)
        {
            Dfs(open, close + 1, n, parentheses, s + ")");
        }
    }

    //Time complexity O(4^n/\sqrt{n})
    //Space complexity O(n)
    public static List<string> GenerateParenthesis(int n)
    {
        var parentheses = new List<string>();
        Dfs(0, 0, n, parentheses, "");
        return parentheses;
    }
}

