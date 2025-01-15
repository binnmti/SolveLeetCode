namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class ValidPalindromeTest
{
    [TestMethod]
    public void ValidPalindrome()
    {
        Assert.AreEqual(IsPalindrome("Was it a car or a cat I saw?"), true);
        Assert.AreEqual(IsPalindrome("tab a cat"), false);
    }

    //Time complexity O(n)
    //Space complexity O(n)
    public bool IsPalindrome(string s)
    {
        s = s.ToUpper();
        var s2 = "";
        foreach (var c in s)
        {
            if ((c >= 'A' && c <= 'Z') || (c >= '0' && c <= '9'))
            {
                s2 += c.ToString();
            }
        }
        var start = "";
        for (int i = 0; i < s2.Length; i++)
        {
            var c = s2[i].ToString();
            start += c;
        }
        var end = "";
        for (int i = s2.Length - 1; i >= 0; i--)
        {
            var c = s2[i].ToString();
            end += c;
        }
        Console.WriteLine(start);
        Console.WriteLine(end);
        return start == end;
    }
}

