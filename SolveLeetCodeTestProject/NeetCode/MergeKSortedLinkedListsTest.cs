namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class MergeKSortedLinkedListsTest
{
    [TestMethod]
    public void MergeKSortedLinkedLists()
    {
    }

    // Time complexity: O(n log n)
    // Space complexity: O(n)
    public ListNode MergeKLists(ListNode[] lists)
    {
        var nodes = new List<int>();
        foreach (var list in lists)
        {
            var cur = list;
            while (cur != null)
            {
                nodes.Add(cur.val);
                cur = cur.next;
            }
        }
        nodes.Sort();

        var result = new ListNode();
        var current = result;
        foreach (var n in nodes)
        {
            current.next = new ListNode(n);
            current = current.next;
        }
        return result.next;
    }
}

