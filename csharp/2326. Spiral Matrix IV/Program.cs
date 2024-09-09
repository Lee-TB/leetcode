using Leetcode.DataStructure;
using Leetcode.Utils;

var sln = new Solution();

int m = 3, n = 5;
int[] headNums = [3, 0, 2, 6, 8, 1, 7, 9, 4, 2, 5, 5, 0];
ListNode head = Converter.ArrayToListNode(headNums);

int[][] matrix = sln.SpiralMatrix(m, n, head);

for (int row = 0; row < m; row++)
{
    for (int col = 0; col < n; col++)
    {
        Console.Write(matrix[row][col] + " ");
    }
    Console.WriteLine();
}

public class Solution
{
    public int[][] SpiralMatrix(int m, int n, ListNode head)
    {
        // initialize the matrix with all values is -1
        int[][] matrix = new int[m][];
        for (int row = 0; row < m; row++)
        {
            matrix[row] = new int[n];
            for (int col = 0; col < n; col++)
            {
                matrix[row][col] = -1;
            }
        }

        // direction in clockwise
        int[][] direction = [
            [-1, 0],
            [0, 1],
            [1, 0],
            [0, -1],
        ];
        int[] curPos = [0, 0]; // current-position start from top-left;
        int curDir = 1; // current-direction right;

        while (head != null)
        {
            matrix[curPos[0]][curPos[1]] = head.val;

            curPos[0] += direction[curDir][0];
            curPos[1] += direction[curDir][1];
            // if new position out of range of matrix or value is set before we change current Direction and reupdate the new position
            if (curPos[0] < 0 || curPos[0] >= m || curPos[1] < 0 || curPos[1] >= n || matrix[curPos[0]][curPos[1]] != -1)
            {
                // roll back previous position
                curPos[0] -= direction[curDir][0];
                curPos[1] -= direction[curDir][1];
                // change direction and update to new position
                curDir = (curDir + 1) % 4;
                curPos[0] += direction[curDir][0];
                curPos[1] += direction[curDir][1];
            }            
            head = head.next;
        }

        return matrix;
    }

    private static int[][] InitializeMatrix(int m, int n, int fillValue = 0)
    {
        int[][] matrix = new int[m][];
        for (int row = 0; row < m; row++)
        {
            matrix[row] = new int[n];
            for (int col = 0; col < n; col++)
            {
                matrix[row][col] = fillValue;
            }
        }
        return matrix;
    }
}