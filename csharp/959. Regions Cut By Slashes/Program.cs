var sln = new Solution();
Console.WriteLine(sln.RegionsBySlashes(["/\\", "\\/"]));
public class Solution
{
    public int RegionsBySlashes(string[] grid)
    {
        int gridSize = grid.GetLength(0);
        int expandedGridSize = gridSize * 3;
        int[,] expandedGrid = new int[expandedGridSize, expandedGridSize];

        for (int i = 0; i < gridSize; i++)
        {
            for (int j = 0; j < gridSize; j++)
            {
                var c = grid[i][j];
                if (c == '/')
                {
                    expandedGrid[i * 3, j * 3 + 2] = 1;
                    expandedGrid[i * 3 + 1, j * 3 + 1] = 1;
                    expandedGrid[i * 3 + 2, j * 3] = 1;
                }
                else if (c == '\\')
                {
                    expandedGrid[i * 3, j * 3] = 1;
                    expandedGrid[i * 3 + 1, j * 3 + 1] = 1;
                    expandedGrid[i * 3 + 2, j * 3 + 2] = 1;
                }
            }
        }

        int regions = 0;
        for (int i = 0; i < expandedGridSize; i++)
        {
            for (int j = 0; j < expandedGridSize; j++)
            {
                if (expandedGrid[i, j] == 0)
                {
                    FloodFill(expandedGrid, i, j);
                    regions++;
                }
            }
        }
        return regions;
    }

    private static void PrintGrid(int[,] expandedGrid)
    {
        int expandedGridSize = expandedGrid.Length;
        for (int i = 0; i < expandedGridSize; i++)
        {
            Console.WriteLine();
            for (int j = 0; j < expandedGridSize; j++)
            {
                Console.Write(expandedGrid[i, j] + " ");
            }
        }
    }

    private void FloodFill(int[,] expandedGrid, int startRow, int startCol)
    {
        int[][] directions = [
            [0, 1],
            [0, -1],
            [1, 0],
            [-1, 0],
        ];
        expandedGrid[startRow, startCol] = 1;
        Stack<int[]> stack = new Stack<int[]>();
        stack.Push(new int[] { startRow, startCol });
        int gridLength = expandedGrid.GetLength(0);

        while (stack.Count > 0)
        {
            var currentCell = stack.Pop();

            foreach (var direction in directions)
            {
                int newRow = currentCell[0] + direction[0];
                int newCol = currentCell[1] + direction[1];

                if (
                    newRow >= 0
                    && newCol >= 0
                    && newRow < gridLength
                    && newCol < gridLength
                    && expandedGrid[newRow, newCol] == 0
                )
                {
                    expandedGrid[newRow, newCol] = 1;
                    stack.Push(new int[] { newRow, newCol });
                }
            }
        }
    }
}