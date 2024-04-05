namespace SolveLeetCodeTestProject;

internal static class Solution002
{
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

