var sln = new Solution();
int[][] grid = [[0, 1, 1, 0], [0, 1, 1, 0], [0, 0, 0, 0]];
grid = [[1, 0]];
System.Console.WriteLine(sln.MinDays(grid));
public class Solution
{
  public int MinDays(int[][] grid)
  {
    int initialNumberOfIlands = CountIslands(grid);

    if (initialNumberOfIlands != 1) return 0;

    // // In one day (per day), we are allowed to change any single land cell (1) into a water cell (0).
    for (int i = 0; i < grid.Length; i++)
    {
      for (int j = 0; j < grid[0].Length; j++)
      {
        if (grid[i][j] == 1)
        {
          grid[i][j] = 0;
          if (CountIslands(grid) != 1) return 1;
          grid[i][j] = 1;
        }
      }
    }

    return 2;
  }

  private int CountIslands(int[][] grid)
  {
    int[][] gridCopy = grid.Select(x => x.ToArray()).ToArray();

    int count = 0;
    for (int i = 0; i < gridCopy.Length; i++)
    {
      for (int j = 0; j < gridCopy[0].Length; j++)
      {
        if (gridCopy[i][j] == 1)
        {
          DFS(gridCopy, i, j);
          count++;
        }
      }
    }
    return count;
  }

  private void DFS(int[][] grid, int sr, int sc)
  {
    if (sr < 0 || sc < 0 || sr >= grid.Length || sc >= grid[0].Length || grid[sr][sc] == 0) return;
    // mark as visited, this will change the grid outside of this function
    grid[sr][sc] = 0;

    DFS(grid, sr + 1, sc);
    DFS(grid, sr - 1, sc);
    DFS(grid, sr, sc + 1);
    DFS(grid, sr, sc - 1);
  }
}