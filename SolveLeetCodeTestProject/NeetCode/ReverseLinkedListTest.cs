namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class ReverseLinkedListTest
{
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    [TestMethod]
    public void ReverseLinkedList()
    {
        //Assert.AreEqual(ReverseList([0, 1, 2, 3]), [3, 2, 1, 0]);
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public ListNode ReverseList(ListNode head)
    {
        if (head == null) return null;

        var reverse = new List<int>();
        while (head != null)
        {
            reverse.Add(head.val);
            head = head.next;
        }

        var newListNode = new ListNode(reverse.Last());
        var next = newListNode;
        for (var i = reverse.Count - 1 - 1; i >= 0; i--)
        {
            next.next = new ListNode(reverse[i]);
            next = next.next;
        }
        return newListNode;
    }
}

