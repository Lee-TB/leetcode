namespace _1331._Rank_Transform_of_an_Array;

public class Solution
{
    public int[] ArrayRankTransform(int[] arr)
    {
        int n = arr.Length;
        int[] sortedArr = new int[n];
        Array.Copy(arr, sortedArr, n);
        Array.Sort(sortedArr);
        Dictionary<int, int> rankMap = new Dictionary<int, int>();

        foreach (int num in sortedArr)
        {
            if (!rankMap.ContainsKey(num))
            {
                rankMap[num] = rankMap.Count + 1;
            }
        }

        int[] ranks = new int[n];
        for (int i = 0; i < n; i++)
        {
            ranks[i] = rankMap[arr[i]];
        }

        return ranks;
    }
}

public class LinqSolution
{
    public int[] ArrayRankTransform(int[] arr)
    {
        int[] sortedArr = arr.Distinct().OrderBy(x => x).ToArray();
        Dictionary<int, int> rankMap = new Dictionary<int, int>();

        foreach (int num in sortedArr)
        {            
            rankMap[num] = rankMap.Count + 1;
        }       

        return arr.Select(x => rankMap[x]).ToArray();
    }
}