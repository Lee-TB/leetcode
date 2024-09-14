var sln = new Solution();
var res = sln.MaxSubArray([-2, 1, -3, 4, -1, 4, 1, -5, 4]);
Console.WriteLine(res);
public class Solution
{
    public int MaxSubArray(int[] nums)
    {
        int maxSum = nums[0], sum = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            sum += nums[i];
            if (sum < nums[i])
            {
                sum = nums[i];
            }
            maxSum = sum > maxSum ? sum : maxSum;
        }
        return maxSum;
    }
}