namespace SolveLeetCodeTestProject;

internal class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

internal static class ListNodeExtensions
{
    internal static ListNode ToListNode(this int[] ints)
    {
        var head = new ListNode();
        var current = head;
        foreach (var i in ints)
        {
            current.next = new ListNode(i);
            current = current.next;
        }
        return head.next ?? new ListNode();
    }

    internal static int[] ToArray(this ListNode? listNode)
    {
        var list = new List<int>();
        while (listNode != null)
        {
            list.Add(listNode.val);
            listNode = listNode.next;
        }
        return [.. list];
    }

    internal static ListNode Reverse(this ListNode? listNode)
    {
        listNode.Reverse();
        return listNode.ToArray().ToListNode();
    }
}