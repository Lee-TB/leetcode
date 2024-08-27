var sln = new Solution();
var result = sln.MaxProbability(3, [[0, 1], [1, 2], [0, 2]], [0.5, 0.5, 0.2], 0, 2);
Console.WriteLine(result);


public class Solution
{
    public double MaxProbability(int n, int[][] edges, double[] succProb, int start_node, int end_node)
    {
        double[] maxProb = new double[n];
        maxProb[start_node] = 1.0;

        for (int i = 0; i < n - 1; i++)
        {
            bool hasUpdate = false;
            for (int j = 0; j < edges.Length; j++)
            {
                var u = edges[j][0];
                var v = edges[j][1];
                var pathProb = succProb[j];
                if (maxProb[u] * pathProb > maxProb[v])
                {
                    maxProb[v] = maxProb[u] * pathProb;
                    hasUpdate = true;
                }
                if (maxProb[v] * pathProb > maxProb[u])
                {
                    maxProb[u] = maxProb[v] * pathProb;
                    hasUpdate = true;
                }
            }
            if(!hasUpdate)
            {
                break;
            }
        }

        return maxProb[end_node];
    }
}