namespace SolveLeetCodeTestProject;


public class TreeNode(int val = 0, TreeNode? left = null, TreeNode? right = null)
{
    public int val = val;
    public TreeNode? left = left;
    public TreeNode? right = right;
}


public static class TreeNodeExtensions
{
    public static TreeNode ToTreeNode(this List<int?> ints)
    {
        var head = new TreeNode(0);
        var current = head;
        foreach (var i in ints)
        {
            current.left = new TreeNode(i.Value);
            current = current.left;
        }
        return head.left ?? new TreeNode(0);
    }

    public static int[] ToArray(this TreeNode? node)
    {
        var list = new List<int>();
        while (node != null)
        {
            list.Add(node.val);
            node = node.left;
        }
        return [.. list];
    }
}