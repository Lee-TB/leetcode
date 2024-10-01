namespace _1497._Check_If_Array_Pairs_Are_Divisible_by_k;

public class Solution
{
    public bool CanArrange(int[] arr, int k)
    {
        int[] remainderCount = new int[k];
        foreach (int num in arr)
            remainderCount[((num % k) + k) % k]++;

        if (remainderCount[0] % 2 != 0)
            return false;

        for (int i = 1; i <= k / 2; i++)
            if (remainderCount[i] != remainderCount[k - i])
                return false;

        return true;
    }
}