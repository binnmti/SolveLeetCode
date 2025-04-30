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
        var node = new ListNode();
        var current = node;
        var carry = 0;
        while (l1 != null || l2 != null || carry != 0)
        {
            var sum = 0;
            if (l1 != null) sum += l1.val;
            if (l2 != null) sum += l2.val;

            var val = (sum + carry) % 10;

            current.next = new ListNode(val);
            current = current.next;

            carry = (sum + carry) / 10;
            l1 = l1?.next;
            l2 = l2?.next;
        }
        return node.next;
    }
}

