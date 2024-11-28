namespace SolveLeetCodeTestProject;

[TestClass]
internal class ValidSudokuTest
{
    [TestMethod]
    public void ValidSudoku()
    {
        var ret = IsValidSudoku(
        [
            ['.', '.', '4', '.', '.', '.', '6', '3', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['5', '.', '.', '.', '.', '.', '.', '9', '.'],
            ['.', '.', '.', '5', '6', '.', '.', '.', '.'],
            ['4', '.', '3', '.', '.', '.', '.', '.', '1'],
            ['.', '.', '.', '7', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '5', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.'],
            ['.', '.', '.', '.', '.', '.', '.', '.', '.']
        ]);
        Assert.AreEqual(ret, true);
    }

    bool IsValidSudoku(char[][] board)
    {
        for (int row = 0; row < 9; row++)
        {
            var dic = new Dictionary<int, char>();
            for (int col = 0; col < 9; col++)
            {
                if (board[row][col] == '.') continue;
                if (dic.ContainsValue(board[row][col])) return false;
                dic[col] = board[row][col];
            }
        }
        for (int col = 0; col < 9; col++)
        {
            var dic = new Dictionary<int, char>();
            for (int row = 0; row < 9; row++)
            {
                if (board[row][col] == '.') continue;
                if (dic.ContainsValue(board[row][col])) return false;
                dic[col] = board[row][col];
            }
        }

        for (int box = 0; box < 9; box++)
        {
            var dic = new Dictionary<int, char>();
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    var cIndex = box % 3 + col;
                    var rIndex = box / 3 + row;

                    if (board[rIndex][cIndex] == '.') continue;
                    if (dic.ContainsValue(board[rIndex][cIndex])) return false;
                    dic[rIndex * 3 + cIndex] = board[rIndex][cIndex];
                }

            }
        }
        return true;
    }
}

