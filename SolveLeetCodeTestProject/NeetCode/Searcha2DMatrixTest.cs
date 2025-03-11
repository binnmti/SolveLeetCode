namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class Searcha2DMatrixTest
{
    [TestMethod]
    public void Searcha2DMatrix()
    {
        Assert.AreEqual(SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 3), true);
        Assert.AreEqual(SearchMatrix([[1, 3, 5]], 0), false);
        Assert.AreEqual(SearchMatrix([[1, 3]], 1), true);
        Assert.AreEqual(SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 13), false);
        Assert.AreEqual(SearchMatrix([[1, 2, 4, 8, 9], [10, 11, 12, 13, 14], [15, 20, 30, 40, 50]], 10), true);
        Assert.AreEqual(SearchMatrix([[1, 2, 4, 8], [10, 11, 12, 13], [14, 20, 30, 40]], 10), true);
        Assert.AreEqual(SearchMatrix([[1, 2, 4, 8], [10, 11, 12, 13], [14, 20, 30, 40]], 15), false);
    }

    // Time complexity: O(log(n * m))
    // Space complexity: O(1)
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int rows = matrix.Length;
        int cols = matrix[0].Length;
        int l = 0;
        int r = rows * cols - 1;
        while (l <= r)
        {
            int center = l + (r - l) / 2;
            int row = center / cols;
            int col = center % cols;

            if (matrix[row][col] < target)
            {
                l = center + 1;
            }
            else if (matrix[row][col] > target)
            {
                r = center - 1;
            }
            else
            {
                return true;
            }
        }
        return false;
    }
}

