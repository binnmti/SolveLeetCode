using System;
using System.Reflection;

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

    //Time complexity O(n^2)
    //Space complexity O(1)
    bool IsValidSudoku(char[][] board)
    {
        for (int row = 0; row < 9; row++)
        {
            var hash = new HashSet<char>();
            for (int col = 0; col < 9; col++)
            {
                var index = board[row][col];
                if (index == '.') continue;
                if (hash.Contains(index)) return false;
                hash.Add(index);
            }
        }
        for (int col = 0; col < 9; col++)
        {
            var hash = new HashSet<char>();
            for (int row = 0; row < 9; row++)
            {
                var index = board[row][col];
                if (index == '.') continue;
                if (hash.Contains(index)) return false;
                hash.Add(index);
            }
        }
        for (int box = 0; box < 9; box++)
        {
            var hash = new HashSet<char>();
            for (int row = 0; row < 3; row++)
            {
                for (int col = 0; col < 3; col++)
                {
                    var cIndex = 3 * (box % 3) + col;
                    var rIndex = 3 * (box / 3) + row;
                    var index = board[rIndex][cIndex];

                    if (index == '.') continue;
                    if (hash.Contains(index)) return false;
                    hash.Add(index);
                }
            }
        }
        return true;
    }
}

