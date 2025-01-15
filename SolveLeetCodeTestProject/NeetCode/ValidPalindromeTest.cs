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
        var normalized = s.Where(char.IsLetterOrDigit).Select(char.ToLower);
        return normalized.SequenceEqual(normalized.Reverse());
    }
}

