namespace SolveLeetCodeTestProject;

[TestClass]
public class AlgorithmsTest
{
    [TestMethod]
    [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 0, 1 })]
    [DataRow(new int[] { 3, 2, 4 }, 6, new int[] { 1, 2 })]
    [DataRow(new int[] { 3, 3 }, 6, new int[] { 0, 1 })]
    public void TwoSum(int[] nums, int target, int[] expected)
    {
        var actual = Algorithms.TwoSum(nums, target);

        CollectionAssert.AreEqual(expected, actual);
    }
}