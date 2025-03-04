namespace SolveLeetCodeTestProject.NeetCode;

[TestClass]
public class Searcha2DMatrixTest
{
    [TestMethod]
    public void Searcha2DMatrix()
    {
        //[[1,3,5]]
        Assert.AreEqual(SearchMatrix([[1, 3, 5]], 0), false);
        Assert.AreEqual(SearchMatrix([[1, 3]], 1), true);
        Assert.AreEqual(SearchMatrix([[1, 3, 5, 7], [10, 11, 16, 20], [23, 30, 34, 60]], 13), false);
        Assert.AreEqual(SearchMatrix([[1, 2, 4, 8, 9], [10, 11, 12, 13, 14], [15, 20, 30, 40, 50]], 10), true);
        Assert.AreEqual(SearchMatrix([[1, 2, 4, 8], [10, 11, 12, 13], [14, 20, 30, 40]], 10), true);
        Assert.AreEqual(SearchMatrix([[1, 2, 4, 8], [10, 11, 12, 13], [14, 20, 30, 40]], 15), false);
    }

    // Time complexity: O(n^2)
    // Space complexity: O(log n * m)
    public bool SearchMatrix(int[][] matrix, int target)
    {
        int i = 0;
        int center = matrix[0].Length / 2;
        int j = center;
        int loop = matrix[0].Length;

        while (loop > 0)
        {
            if (matrix[i][^1] < target)
            {
                i++;
                if (i == matrix.Length) break;
                center = matrix[i].Length / 2;
                loop = matrix[i].Length;
            }
            else
            {
                center = (center / 2) != 0 ? center / 2 : 1;
                if (matrix[i][j] < target)
                {
                    j += center;
                    if (j > matrix[i].Length - 1) break;
                }
                else if (matrix[i][j] > target)
                {
                    j -= center;
                    if (j < 0) break;
                }
                else
                {
                    return true;
                }
                loop--;
            }
        }
        return false;
    }
}

