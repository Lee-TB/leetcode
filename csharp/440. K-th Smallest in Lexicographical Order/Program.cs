
var sln = new Solution();
int n = 101, k = 3;
int n1 = 1000000000;
int a = 2000000000;
var res = sln.FindKthNumber(n, k);
public class Solution
{
    public int FindKthNumber(int n, int k)
    {
        int currentNumber = 1;
        k--;

        while (k > 0)
        {
            int steps = CountSteps(n, currentNumber, currentNumber + 1);
            if (steps <= k)
            {
                currentNumber++;
                k -= steps;
            }
            else
            {
                currentNumber *= 10;
                k--;
            }
        }

        return currentNumber;
    }

    private static int CountSteps(int n, long prefix1, long prefix2)
    {
        int steps = 0;
        while (prefix1 <= n)
        {
            steps += (int)(Math.Min(n + 1, prefix2) - prefix1);
            prefix1 *= 10;
            prefix2 *= 10;
        }
        return steps;
    }
}