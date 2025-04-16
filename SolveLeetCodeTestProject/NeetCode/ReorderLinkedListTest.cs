namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class ReorderLinkedListTest
{
    [TestMethod]
    public void ReorderLinkedList()
    {
        var expected = ListNodeExtensions.ToListNode([2, 4, 6, 8]);
        ReorderList(expected);
        var actual = ListNodeExtensions.ToListNode([2, 8, 4, 6]);
        Assert.IsTrue(expected.Equal(actual));
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public void ReorderList(ListNode head)
    {
        var nodes = new List<ListNode>();
        var next = head;
        while (next != null)
        {
            nodes.Add(next);
            next = next.next;
        }
        var l = 0;
        var r = nodes.Count - 1;
        while (l < r)
        {
            nodes[l].next = nodes[r];
            l++;

            if (l >= r) break;

            nodes[r].next = nodes[l];
            r--;
        }
        nodes[l].next = null;
    }
}

