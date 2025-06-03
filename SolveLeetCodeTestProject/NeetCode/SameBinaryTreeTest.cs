namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class SameBinaryTreeTest
{
    [TestMethod]
    public void SameBinaryTree()
    {
        var expected = IsSameTree(TreeNodeExtensions.ToTreeNode([1, 2, 3]), TreeNodeExtensions.ToTreeNode([1, 2, 3]));
        //var actual = NodeExtensions.ToArray([1, 2, 4]);
        //Assert.IsTrue(expected.Equal(actual));
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public bool IsSameTree(TreeNode? p, TreeNode? q)
    {
        if (p != null && q != null)
        {
            if (!IsSameTree(p.left, q.left)) return false;
            if (!IsSameTree(p.right, q.right)) return false;
            return p.val == q.val;
        }
        return p == null && q == null;

    }
}

