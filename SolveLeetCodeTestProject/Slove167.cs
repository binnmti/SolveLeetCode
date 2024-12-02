using FluentAssertions;

namespace SolveLeetCodeTestProject;

[TestClass]
public class Slove167
{
    /*
    167. Two Sum II - Input Array Is Sorted
    Medium
    Topics
    Companies
    Given a 1-indexed array of integers numbers that is already sorted in non-decreasing order, find two numbers such that they add up to a specific target number. Let these two numbers be numbers[index1] and numbers[index2] where 1 <= index1 < index2 <= numbers.length.

    Return the indices of the two numbers, index1 and index2, added by one as an integer array [index1, index2] of length 2.

    The tests are generated such that there is exactly one solution. You may not use the same element twice.

    Your solution must use only constant extra space.
    */
    public int[] TwoSum(int[] numbers, int target)
    {
        for(int i = 0; i < numbers.Length; i++)
        {
            for (int j = i + 1; j < numbers.Length; j++)
            {
                if (numbers[i] + numbers[j] == target)
                {
                    return [i + 1, j + 1];
                }
            }
        }
        return [];
    }

    [TestMethod]
    [DataRow(new int[] { 2, 7, 11, 15 }, 9, new int[] { 1, 2 })]
    [DataRow(new int[] { 2, 3, 4 }, 6, new int[] { 1, 3 })]
    [DataRow(new int[] { -1, 0 }, -1, new int[] { 1, 2})]
    public void TestMethod1(int[] numbers, int target, int[] expected)
    {
        var actual = TwoSum(numbers, target);
        //•’Ê‚ÍAsseeet.AreEqual‚¾‚ªA”z—ñ‚É‚ÍŽg‚¦‚È‚¢
        CollectionAssert.AreEqual(expected, actual);
    }
}