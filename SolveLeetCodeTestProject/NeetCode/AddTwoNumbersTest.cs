namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class AddTwoNumbersTest
{
    [TestMethod]
    public void AddTwoNumbers()
    {
        var expected = AddTwoNumbers(ListNodeExtensions.ToListNode([1, 2, 3]), ListNodeExtensions.ToListNode([4, 5, 6]));
        var actual = ListNodeExtensions.ToListNode([5, 7, 9]);
        Assert.IsTrue(expected.Equal(actual));
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        var dummy = new ListNode();
        var current = dummy;
        var carry = 0;
        while (l1 != null || l2 != null || carry != 0)
        {
            var v1 = l1 != null ? l1.val : 0;
            var v2 = l2 != null ? l2.val : 0;

            var val = v1 + v2 + carry;
            carry = val / 10;
            val = val % 10;

            current.next = new ListNode(val);
            current = current.next;

            l1 = l1?.next;
            l2 = l2?.next;
        }
        return dummy.next;
    }
}

