var sln = new Solution();
int[][] arrays = [[1, 4], [0, 5]];
Console.WriteLine(sln.MaxDistance(arrays));
public class Solution
{
    public int MaxDistance(IList<IList<int>> arrays)
    {        
        int maxDistance = 0, minValue = arrays[0].Min(), maxValue = arrays[0].Max();

        for (int i = 1; i < arrays.Count; i++)
        {
            maxDistance = Math.Max(maxDistance, Math.Abs(maxValue - arrays[i].Min()));
            maxDistance = Math.Max(maxDistance, Math.Abs(minValue - arrays[i].Max()));
            minValue = Math.Min(arrays[i].Min(), minValue);
            maxValue = Math.Max(arrays[i].Max(), maxValue);
        }

        return maxDistance;
    }
}