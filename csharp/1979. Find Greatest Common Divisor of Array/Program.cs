int[] nums = [2, 5, 6, 9, 10];
var sln = new Solution();
int gcd = sln.FindGCD(nums);

Console.WriteLine(gcd);

public class Solution
{
    public int FindGCD(int[] nums)
    {
        int minValue = 1000;
        int maxValue = 1;
        foreach (int num in nums)
        {
            minValue = Min(minValue, num);
            maxValue = Max(maxValue, num);
        }
        return GCD(minValue, maxValue);
    }

    public int GCD(int a, int b)
    {
        if (b == 0) return a;
        return GCD(b, a % b);
    }

    public int Min(int a, int b)
    {
        return a < b ? a : b;
    }

    public int Max(int a, int b)
    {
        return a > b ? a : b;
    }
}