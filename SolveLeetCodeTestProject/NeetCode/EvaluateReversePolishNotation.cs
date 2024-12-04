namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class EvaluateReversePolishNotationTest
{
    [TestMethod]
    public void EvaluateReversePolishNotation()
    {
        Assert.AreEqual(EvalRPN(["10", "6", "9", "3", "+", "-11", "*", "/", "*", "17", "+", "5", "+"]), 5);
    }

    public int EvalRPN(string[] tokens)
    {
        var stack = new Stack<int>();
        foreach(var token in tokens)
        {
            if (token == "+" || token == "-" || token == "*" || token == "/")
            {
                var p1 = stack.Pop();
                var p2 = stack.Pop();
                var r = token switch
                {
                    "+" => p2 + p1,
                    "-" => p2 - p1,
                    "*" => p2 * p1,
                    "/" => p2 / p1,
                    _ => 0,
                };
                stack.Push(r);
            }
            else if (int.TryParse(token, out var n))
            {
                stack.Push(n);
            }
        }
        return stack.Pop();
    }
}
