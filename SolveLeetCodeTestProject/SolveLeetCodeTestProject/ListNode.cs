namespace SolveLeetCodeTestProject;

internal class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

internal static class ListNodeExtensions
{
    internal static ListNode GetListNode(this int[] ints)
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

    internal static int[] GetArray(this ListNode? listNode)
    {
        var list = new List<int>();
        while (listNode != null)
        {
            list.Add(listNode.val);
            listNode = listNode.next;
        }
        return [.. list];
    }
}