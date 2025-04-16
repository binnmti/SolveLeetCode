namespace SolveLeetCodeTestProject;

public class ListNode(int val = 0, ListNode? next = null)
{
    public int val = val;
    public ListNode? next = next;
}

public static class ListNodeExtensions
{
    public static ListNode ToListNode(this int[] ints)
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

    public static int[] ToArray(this ListNode? listNode)
    {
        var list = new List<int>();
        while (listNode != null)
        {
            list.Add(listNode.val);
            listNode = listNode.next;
        }
        return [.. list];
    }

    public static ListNode Reverse(this ListNode? listNode)
    {
        listNode.Reverse();
        return listNode.ToArray().ToListNode();
    }

    public static bool Equal(this ListNode first, ListNode second)
    {
        var a = first;
        var b = second;

        while (a != null && b != null)
        {
            if (a.val != b.val)
                return false;

            a = a.next;
            b = b.next;
        }
        return a == null && b == null;
    }
}