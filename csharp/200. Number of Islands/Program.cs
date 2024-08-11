var sln = new Solution();
char[][] grid = [
  ['1','1','0','0','0'],
  ['1','1','0','0','0'],
  ['0','0','1','0','0'],
  ['0','0','0','1','1']
];
// char[][] grid = new char[][]
// {
//   new char[] {'1', '1', '0', '0', '0'},
//   new char[] {'1', '1', '0', '0', '0'},
//   new char[] {'0', '0', '1', '0', '0'},
//   new char[] {'0', '0', '0', '1', '1'}
// };
System.Console.WriteLine(sln.NumIslands(grid));

public class Solution
{
  public int NumIslands(char[][] grid)
  {
    int count = 0;
    for (int i = 0; i < grid.Length; i++)
    {
      for (int j = 0; j < grid[0].Length; j++)
      {
        if (grid[i][j] == '1')
        {
          DFS(grid, i, j);
          count++;
        }
      }
    }
    return count;
  }

  private void DFS(char[][] grid, int sr, int sc)
  {
    if (sr < 0 || sc < 0 || sr >= grid.Length || sc >= grid[0].Length || grid[sr][sc] == '0')
    {
      return;
    }

    grid[sr][sc] = '0';

    DFS(grid, sr + 1, sc);
    DFS(grid, sr - 1, sc);
    DFS(grid, sr, sc + 1);
    DFS(grid, sr, sc - 1);
  }
}