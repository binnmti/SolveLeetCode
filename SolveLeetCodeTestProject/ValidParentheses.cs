namespace SolveLeetCodeTestProject;

[TestClass]
public class ValidParenthesesTest
{
    [TestMethod]
    public void ValidParentheses()
    {
        Assert.IsTrue(IsValid("[]"));
        Assert.IsTrue(IsValid("([{}])"));
        Assert.IsTrue(!IsValid("[(])"));
    }

    public bool IsValid(string s)
    {
        // Time complexity: O(n)
        // Space complexity: O(n)
        var stack = new Stack<char>();
        for (int i = 0; i < s.Length; i++)
        {
            if (s[i] == '(')
            {
                stack.Push(')');
            }
            else if (s[i] == '[')
            {
                stack.Push(']');
            }
            else if (s[i] == '{')
            {
                stack.Push('}');
            }
            else if (stack.Count == 0 || stack.Pop() != s[i])
            {
                return false;
            }
        }
        return stack.Count == 0;
    }
}

