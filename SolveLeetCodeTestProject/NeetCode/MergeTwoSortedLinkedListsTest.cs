namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class MergeTwoSortedLinkedListsTest
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
    public void MergeTwoSortedLinkedLists()
    {
        //Assert.AreEqual(ReverseList([0, 1, 2, 3]), [3, 2, 1, 0]);
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        var dummy = new ListNode();
        var node = dummy;
        while (list1 != null && list2 != null)
        {
            if (list1.val < list2.val)
            {
                node.next = list1;
                list1 = list1.next;
            }
            else
            {
                node.next = list2;
                list2 = list2.next;
            }
            node = node.next;
        }
        if (list1 != null)
        {
            node.next = list1;
        }
        else
        {
            node.next = list2;
        }
        return dummy.next;
    }
}

