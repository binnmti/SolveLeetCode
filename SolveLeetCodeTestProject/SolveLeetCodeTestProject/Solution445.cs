using static SolveLeetCodeTestProject.Solution002;

namespace SolveLeetCodeTestProject;

internal static class Solution445
{

    //[TestMethod]
    //[DataRow(new int[] { 1, 2, 3 }, new int[] { 4, 5 }, new int[] { 1, 6, 8 })]
    internal static ListNode Reverse(ListNode? l1)
    {
        var list = new List<int>();
        //Key Valueにしないと、桁分からない気がする。
        var listNode = new ListNode();
        while (true)
        {
            var sum = (l1?.val ?? 0);
            list.Add(sum);
            l1 = l1?.next;
            if (l1 == null) break;
        }
        list.Reverse();
        return list.ToArray().GetListNode();
    }

    internal static ListNode AddTwoNumbers(ListNode? l1, ListNode? l2)
    {
        l1 = Reverse(l1);
        l2 = Reverse(l2);

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

        listNode = Reverse(listNode);

        return listNode;
    }
}
