//https://leetcode.com/problems/magic-squares-in-grid/description/?envType=daily-question&envId=2024-08-09
using System.Text;
var sln = new Solution();
var output = sln.NumMagicSquaresInside(new int[][] {
    new int[] {4,3,8,4},
    new int[] {9,5,1,9},
    new int[] {2,7,6,2}
});
System.Console.WriteLine(output);
public class Solution
{
  public int NumMagicSquaresInside(int[][] grid)
  {
    int count = 0;
    for (int i = 0; i < grid.Length - 2; i++)
    {
      for (int j = 0; j < grid[0].Length - 2; j++)
      {
        if (IsMagicSquare(grid, i, j))
        {
          count++;
        }
      }
    }
    return count;
  }

  public bool IsMagicSquare(int[][] grid, int row, int col)
  {
    string sequence = "2943816729438167";
    string sequenceReverse = "7618349276183492";
    StringBuilder border = new StringBuilder();
    int[] borderIndices = new int[] { 0, 1, 2, 5, 8, 7, 6, 3 };
    for (int i = 0; i < 8; i++)
    {
      var cell = grid[row + borderIndices[i] / 3][col + borderIndices[i] % 3];
      border.Append(cell);
    }
    string borderStr = border.ToString();

    var isCornerEven = grid[row][col] % 2 == 0;
    var isCenterFive = grid[row + 1][col + 1] == 5;
    var isBorderValid = sequence.Contains(borderStr)
      || sequenceReverse.Contains(borderStr);

    return isCornerEven && isCenterFive && isBorderValid;
  }
}