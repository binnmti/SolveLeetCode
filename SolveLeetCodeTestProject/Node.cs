namespace SolveLeetCodeTestProject;

public class Node
{
    public int val;
    public Node next;
    public Node random;

    public Node(int _val)
    {
        val = _val;
        next = null;
        random = null;
    }
}

public static class NodeExtensions
{
    public static Node ToNode(this List<int?[]> ints)
    {
        var head = new Node(0);
        var current = head;
        foreach (var i in ints)
        {
            current.next = new Node(i.First().Value);
            current = current.next;
        }
        return head.next ?? new Node(0);
    }

    public static int[] ToArray(this Node? node)
    {
        var list = new List<int>();
        while (node != null)
        {
            list.Add(node.val);
            node = node.next;
        }
        return [.. list];
    }
}