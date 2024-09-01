var sln = new Solution();
int[] original = [1, 2, 3, 4];
int m = 2, n = 2;
var result = sln.Construct2DArray(original, m, n);

for (int row = 0; row < m; row++)
{
    for (int col = 0; col < n; col++)
    {
        Console.Write(result[row][col] + " ");
    }
    Console.WriteLine();
}

public class Solution
{
    public int[][] Construct2DArray(int[] original, int m, int n)
    {
        if (original.Length != m * n) return [];

        int[][] _2dArray = new int[m][];
        for (int i = 0; i < m; i++)
        {
            _2dArray[i] = new int[n];
        }

        for (int i = 0; i < m * n; i++)
        {
            _2dArray[i / n][i % n] = original[i];
        }

        return _2dArray;
    }
}