namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class ReverseLinkedListTest
{
    [TestMethod]
    public void ReverseLinkedList()
    {
        var expected = ReverseList(ListNodeExtensions.ToListNode([0, 1, 2, 3]));
        var actual = ListNodeExtensions.ToListNode([3, 2, 1, 0]);
        Assert.IsTrue(expected.Equal(actual));
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public ListNode ReverseList(ListNode head)
    {
        ListNode prev = null!;
        var current = head;
        while (current != null)
        {
            var temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        return prev;
    }
}

