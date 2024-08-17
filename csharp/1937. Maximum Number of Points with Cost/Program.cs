var sln = new Solution();
int[][] points = [[1, 2, 3], [1, 5, 1], [3, 1, 1]];
sln.MaxPoints(points);
public class Solution
{
    public long MaxPoints(int[][] points)
    {
        int rows = points.Length, cols = points[0].Length;
        long[] previousRow = new long[cols];

        // initialize first row
        for (int col = 0; col < cols; col++)
        {
            previousRow[col] = points[0][col];
        }

        // process each row
        for (int row = 1; row < rows; row++)
        {
            long[] leftMax = new long[cols];
            long[] rightMax = new long[cols];
            long[] currentRow = new long[cols];

            // calculate left-to-right maximum
            leftMax[0] = previousRow[0];
            for (int col = 1; col < cols; col++)
            {
                leftMax[col] = Math.Max(previousRow[col], leftMax[col - 1] - 1);
            }

            // calculate right-to-left maximun
            rightMax[cols - 1] = previousRow[cols - 1];
            for (int col = cols - 2; col >= 0; col--)
            {
                rightMax[col] = Math.Max(previousRow[col], rightMax[col + 1] - 1);
            }

            for (int col = 0; col < cols; col++)
            {
                currentRow[col] = points[row][col] + Math.Max(leftMax[col], rightMax[col]);
            }
            previousRow = currentRow;
        }

        long maxPoints = 0;
        for (int col = 0; col < cols; col++)
        {
            maxPoints= Math.Max(maxPoints, previousRow[col]);
        }   
        return maxPoints;
    }
}