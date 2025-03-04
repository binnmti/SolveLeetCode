namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class Searcha2DMatrixTest
{
    [TestMethod]
    public void Searcha2DMatrix()
    {
        Assert.AreEqual(SearchMatrix([[1, 2, 4, 8], [10, 11, 12, 13], [14, 20, 30, 40]], 10), true);
        Assert.AreEqual(SearchMatrix([[1, 2, 4, 8], [10, 11, 12, 13], [14, 20, 30, 40]], 15), false);
    }

    // Time complexity: O(n^2)
    // Space complexity: O(1)
    public bool SearchMatrix(int[][] matrix, int target)
    {
        for (int i = 0; i < matrix.Length; i++)
        {
            for (int j = 0; j < matrix[i].Length; j++)
            {
                if (target == matrix[i][j])
                {
                    return true;
                }
            }
        }
        return false;
    }
}

