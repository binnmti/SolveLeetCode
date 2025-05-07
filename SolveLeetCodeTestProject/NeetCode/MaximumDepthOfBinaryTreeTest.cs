namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class MaximumDepthOfBinaryTreeTest
{
    [TestMethod]
    public void MaximumDepthOfBinaryTree()
    {
        var expected = MaxDepth(TreeNodeExtensions.ToTreeNode([1, 2, 3, null, null, 4]));
        //var actual = NodeExtensions.ToArray([1, 2, 4]);
        //Assert.IsTrue(expected.Equal(actual));
    }

    // Time complexity: O(n)
    // Space complexity: O(n)
    public int MaxDepth(TreeNode root)
    {
        if (root == null) return 0;

        return 1 + Math.Max(MaxDepth(root.left), MaxDepth(root.right));
    }
}

