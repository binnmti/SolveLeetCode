namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class CopyLinkedListwithRandomPointerTest
{
    [TestMethod]
    public void CopyLinkedListwithRandomPointer()
    {
        var expected = copyRandomList(NodeExtensions.ToNode([[1, null], [2, 2], [3, 2]]));
        //var actual = NodeExtensions.ToArray([1, 2, 4]);
        //Assert.IsTrue(expected.Equal(actual));
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public Node copyRandomList(Node head)
    {
        var dic = new Dictionary<Node, Node>();
        var current = head;
        while (current != null)
        {
            var newNode = new Node(current.val);
            dic[current] = newNode;
            current = current.next;
        }

        current = head;
        while (current != null)
        {
            var copy = dic[current];
            copy.next = current.next != null ? dic[current.next] : null;
            copy.random = current.random != null ? dic[current.random] : null;
            current = current.next;
        }
        return head != null ? dic[head] : null;
    }
}

