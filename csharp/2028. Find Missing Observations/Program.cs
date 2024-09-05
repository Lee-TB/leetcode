int[] rolls = [4, 5, 6, 2, 3, 6, 5, 4, 6, 4, 5, 1, 6, 3, 1, 4, 5, 5, 3, 2, 3, 5, 3, 2, 1, 5, 4, 3, 5, 1, 5]; int mean = 4; int n = 40;
var sln = new Solution();
var arr = sln.MissingRolls(rolls, mean, n);
foreach (var item in arr)
{
    Console.Write(item + " ");
}

public class Solution
{
    public int[] MissingRolls(int[] rolls, int mean, int n)
    {
        int m = rolls.Length;
        int sumOfPresentRolls = rolls.Sum();
        int sumOfAllRolls = mean * (m + n);
        int sumOfMissingRolls = sumOfAllRolls - sumOfPresentRolls;

        // check for Constraints 1 <= rolls[i] <= 6
        if (sumOfMissingRolls > 6 * n || sumOfMissingRolls < n) return [];

        int rolli = sumOfMissingRolls / n;
        int mod = sumOfMissingRolls % n;

        int[] arr = new int[n];
        for (int i = 0; i < n; i++)
        {
            arr[i] = rolli + (mod > 0 ? 1 : 0);
            mod--;
        }

        return arr;
    }
}