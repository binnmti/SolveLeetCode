namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class LinkedListCycleDetectionTest
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
    public void LinkedListCycleDetection()
    {
        //Assert.AreEqual(ReverseList([0, 1, 2, 3]), [3, 2, 1, 0]);
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public bool HasCycle(ListNode head)
    {
        var hit = new List<int>();
        var next = head;
        while (next != null)
        {
            if (hit.Any(x => x == next.val))
            {
                return true;
            }
            hit.Add(next.val);
            next = next.next;
        }
        return false;
    }
}

