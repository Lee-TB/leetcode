int[] arr = [1, 3, 4, 8];
int[][] queries = [[0, 1], [1, 2], [0, 3], [3, 3]];

var sln = new Solution();
var res = sln.XorQueries(arr, queries);

foreach (int i in res)
{
    Console.Write(i + " ");
}

public class Solution
{
    public int[] XorQueries(int[] arr, int[][] queries)
    {
        int[] ans = new int[queries.Length];
        int i = 0;
        foreach (var query in queries)
        {
            int xor = 0;
            for (int j = query[0]; j <= query[1]; j++)
            {
                xor ^= arr[j];                
            }
            ans[i++] = xor;
        }
        return ans;
    }
}