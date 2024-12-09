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

    //Time complexity O(2^2n)
    //Space complexity O(n)
    List<string> GenerateParenthesis(int n)
    {
        var list = new List<string>();
        for (int i = 0; i < Math.Pow(2, 2 * n); i++)
        {
            bool isValid = true;
            string parenth = "";
            var stack = new Stack<string>();
            for (int j = 0; j < 2 * n; j++)
            {
                bool open = (i & (int)Math.Pow(2, j)) == 0;

                parenth += open ? "(" : ")";
                if (open)
                {
                    stack.Push("(");
                }
                else
                {
                    if (stack.Count == 0)
                    {
                        isValid = false;
                        break;
                    }
                    stack.Pop();
                }
            }
            if (isValid && stack.Count == 0)
            {
                list.Add(parenth);
            }
        }
        return list;
    }
}

