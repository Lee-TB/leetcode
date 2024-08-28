var sln = new Solution();

int[][] grid1 = [[1, 1, 1, 0, 0], [0, 1, 1, 1, 1], [0, 0, 0, 0, 0], [1, 0, 0, 0, 0], [1, 1, 0, 1, 1]];
int[][] grid2 = [[1, 1, 1, 0, 0], [0, 0, 1, 1, 1], [0, 1, 0, 0, 0], [1, 0, 1, 1, 0], [0, 1, 0, 1, 0]];

Console.WriteLine(sln.CountSubIslands(grid1, grid2));
public class Solution
{
    public int CountSubIslands(int[][] grid1, int[][] grid2)
    {
        int count = 0;

        int rows = grid2.Length;
        int cols = grid2[0].Length;
        List<int[]> island = new List<int[]>();

        for (int row = 0; row < rows; row++)
        {
            for (int col = 0; col < cols; col++)
            {
                if (grid2[row][col] == 1)
                {
                    PrintGrid(grid2);
                    // Find in grid2 all seperate islands and consider these are sub-islands.
                    DFS(grid2, row, col, island);

                    if (IsSubIlands(island, grid1))
                        count++;
                    
                    island.Clear();
                }
            }
        }
        return count;
    }

    private bool IsSubIlands(List<int[]> island, int[][] grid1)
    {
        foreach (var cell in island)
        {
            if (grid1[cell[0]][cell[1]] != 1) return false;            
        }
        return true;
    }

    private void DFS(int[][] grid2, int row, int col, List<int[]> island)
    {
        int rows = grid2.Length;
        int cols = grid2[0].Length;
        
        if (row < 0 || col < 0 || row >= rows || col >= cols) return;
        if (grid2[row][col] != 1)
            return;
        
        grid2[row][col] = 0; // turn island 1 to water 0 (important)
        island.Add([row, col]);

        DFS(grid2, row, col + 1, island);
        DFS(grid2, row + 1, col, island);
        DFS(grid2, row, col - 1, island);
        DFS(grid2, row - 1, col, island);
    }


    private static void PrintGrid(int[][] grid)
    {
        Thread.Sleep(10000);
        Console.Clear();
        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[0].Length; j++)
            {
                Console.Write(grid[i][j] + " ");
            }
            Console.WriteLine();
        }
    }
}