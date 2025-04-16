namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class MergeTwoSortedLinkedListsTest
{
    [TestMethod]
    public void MergeTwoSortedLinkedLists()
    {
        //Assert.AreEqual(ReverseList([0, 1, 2, 3]), [3, 2, 1, 0]);
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public ListNode MergeTwoLists(ListNode list1, ListNode list2)
    {
        if (list1 == null && list2 == null) return null;

        var newList = new ListNode();
        var nextList = newList;
        var current1 = list1;
        var current2 = list2;
        while (current1 != null || current2 != null)
        {
            if (current1 != null)
            {
                if (current2 == null || current1.val <= current2.val)
                {
                    nextList.val = current1.val;
                    current1 = current1.next;
                    if (current1 != null || current2 != null)
                    {
                        nextList.next = new ListNode();
                        nextList = nextList.next;
                    }
                }
            }

            if (current2 != null)
            {
                if (current1 == null || current1.val >= current2.val)
                {
                    nextList.val = current2.val;
                    current2 = current2.next;
                    if (current1 != null || current2 != null)
                    {
                        nextList.next = new ListNode();
                        nextList = nextList.next;
                    }
                }
            }
        }
        nextList = null;
        return newList;
    }
}

