var sln = new Solution();
Console.WriteLine(sln.SmallestDistancePair([1, 6, 1], 3));

public class Solution
{
    public int SmallestDistancePair(int[] nums, int k)
    {
        int arrLen = nums.Length;

        int maxValue = int.MinValue;
        foreach (int num in nums)
        {
            maxValue = Math.Max(maxValue, num);
        }

        int[] distanceBucket = new int[maxValue + 1];
        for (int i = 0; i < arrLen; i++)
            for (int j = i + 1; j < arrLen; j++)
            {
                int distance = Math.Abs(nums[i] - nums[j]);
                ++distanceBucket[distance];
            }

        for (int dist = 0; dist <= maxValue; ++dist)
        {
            k -= distanceBucket[dist];
            if (k <= 0) return dist;
        }

        return -1;
    }
}