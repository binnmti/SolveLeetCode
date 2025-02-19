namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class PermutationInStringTest
{
    [TestMethod]
    public void PermutationInString()
    {
        Assert.AreEqual(CheckInclusion("adc", "dcda"), true);
        Assert.AreEqual(CheckInclusion("abc", "lecabee"), true);
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public static bool CheckInclusion(string s1, string s2)
    {
        if (s1.Length > s2.Length) return false;

        var s1Count = new int[26];
        var s2Count = new int[26];

        for (int i = 0; i < s1.Length; i++)
        {
            s1Count[s1[i] - 'a']++;
            s2Count[s2[i] - 'a']++;
        }
        if (IsEqual(s1Count, s2Count)) return true;
        for (int i = s1.Length; i < s2.Length; i++)
        {
            s2Count[s2[i] - 'a']++;
            s2Count[s2[i - s1.Length] - 'a']--;

            if (IsEqual(s1Count, s2Count)) return true;
        }
        return false;
    }

    private static bool IsEqual(int[] s1Count, int[] s2Count)
    {
        for (int i = 0; i < 26; i++)
        {
            if (s1Count[i] != s2Count[i])
            {
                return false;
            }
        }
        return true;
    }
}

