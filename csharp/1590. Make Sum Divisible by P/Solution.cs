namespace _1590._Make_Sum_Divisible_by_P;

public class Solution
{
    public int MinSubarray(int[] nums, int p)
    {
        int n = nums.Length;
        int totalRemainder = 0;
        foreach (int num in nums) {
            totalRemainder = (totalRemainder + num) % p;
        }

        if (totalRemainder == 0) return 0;

        int[] subarrayRemainders = new int[n];
        for (int len = 1; len < n; len++)
        {
            for (int start = 0; start <= n - len; start++)
            {
                subarrayRemainders[start] = (subarrayRemainders[start] + nums[start + len - 1]) % p;
                if ((subarrayRemainders[start] - totalRemainder) % p == 0)
                {
                    return len;
                }
            }
        }

        return -1;
    }
}
