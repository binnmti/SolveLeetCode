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
        ListNode prev = null!;
        var current = head;
        while (current != null)
        {
            var temp = current.next;
            current.next = prev;
            prev = current;
            current = temp;
        }
        return prev;
    }
}

