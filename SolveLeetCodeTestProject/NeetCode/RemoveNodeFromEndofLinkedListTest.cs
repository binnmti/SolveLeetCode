namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class RemoveNodeFromEndofLinkedListTest
{
    [TestMethod]
    public void RemoveNodeFromEndofLinkedList()
    {
        var expected = RemoveNthFromEnd(ListNodeExtensions.ToListNode([1, 2, 3, 4]), 2);
        var actual = ListNodeExtensions.ToListNode([1, 2, 4]);
        Assert.IsTrue(expected.Equal(actual));
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public ListNode RemoveNthFromEnd(ListNode head, int n)
    {
        var lists = new List<ListNode>();
        var current = head;
        while (current != null)
        {
            lists.Add(current);
            current = current.next;
        }

        var removeIndex = lists.Count - n;
        if (removeIndex == 0)
        {
            return head.next;
        }
        lists[removeIndex - 1].next = lists[removeIndex].next;
        return head;
    }
}

