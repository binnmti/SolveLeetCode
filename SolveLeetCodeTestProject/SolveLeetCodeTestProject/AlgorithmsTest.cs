namespace SolveLeetCodeTestProject;

[TestClass]
public class AlgorithmsTest
{
    [TestMethod]
    [DataRow("abcabcbb", 3)]
    public void AlgorithmsTest3(string s, int expected)
    {
        var actual = Solution003.LengthOfLongestSubstring(s);
        Assert.Equals(expected, actual);
    }

    [TestMethod]
    [DataRow(new int[] { 7, 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 8, 0, 7 })]
    [DataRow(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 8, 0, 7 })]
    [DataRow(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
    public void AlgorithmsTest445(int[] l1, int[] l2, int[] expected)
    {
        var actual = Solution445.AddTwoNumbers(l1.GetListNode(), l2.GetListNode());
        CollectionAssert.AreEqual(expected, actual.GetArray());
    }

    [TestMethod]
    [DataRow(new int[] { 2, 4, 3 }, new int[] { 5, 6, 4 }, new int[] { 7, 0, 8 })]
    [DataRow(new int[] { 0 }, new int[] { 0 }, new int[] { 0 })]
    [DataRow(new int[] { 9, 9, 9, 9, 9, 9, 9 }, new int[] { 9, 9, 9, 9 }, new int[] { 8, 9, 9, 9, 0, 0, 0, 1 })]
    public void AlgorithmsTest2(int[] l1, int[] l2, int[] expected)
    {
        var actual = Solution002.AddTwoNumbers(l1.GetListNode(), l2.GetListNode());

        CollectionAssert.AreEqual(expected, actual.GetArray());
    }

    [TestMethod]
    [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void AlgorithmsTest1(int[] nums, int target, int[] expected)
    {
        var actual = Solution001.TwoSum(nums, target);

        CollectionAssert.AreEqual(expected, actual);
    }
}