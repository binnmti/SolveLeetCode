using static SolveLeetCodeTestProject.Solution002;

namespace SolveLeetCodeTestProject;

internal static class Solution002
{
    internal class ListNode(int val = 0, ListNode? next = null)
    {
        public int val = val;
        public ListNode? next = next;
    }

    internal static ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        var listNode = new ListNode();
        var currentNode = listNode;
        var carry = 0;
        while (true)
        {
            var sum = (l1?.val ?? 0) + (l2?.val ?? 0) + carry;
            currentNode.val = sum % 10;
            carry = sum / 10;
            l1 = l1?.next;
            l2 = l2?.next;
            if (l1 == null && l2 == null && carry == 0) break;

            currentNode.next = new ListNode();
            currentNode = currentNode.next;
        }
        return listNode;
    }
}

internal static class Solution2Extensions
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