
using System.Text;

var sln = new Solution();
Console.WriteLine(sln.StrangePrinter("abcdefha"));
public class Solution
{
    public int StrangePrinter(string s)
    {
        s = RemoveDuplicates(s);
        int n = s.Length;
        int[,] memo = new int[n, n];

        return MinimumTurns(0, n - 1, s, memo);
    }

    private int MinimumTurns(int start, int end, string s, int[,] memo)
    {
        if (start > end) return 0;

        if (memo[start, end] != 0) return memo[start, end];

        int minTurns = MinimumTurns(start + 1, end, s, memo) + 1;

        for (int i = start + 1; i <= end; i++)
        {
            if (s[i] == s[start])
            {
                var turnsWithSameChar = MinimumTurns(start, i - 1, s, memo) + MinimumTurns(i + 1, end, s, memo);
                minTurns = Math.Min(minTurns, turnsWithSameChar);
            }
        }

        memo[start, end] = minTurns;
        return minTurns;
    }

    private string RemoveDuplicates(string s)
    {
        StringBuilder stringBuilder = new StringBuilder();
        int i = 0;
        while (i < s.Length)
        {
            var currentChar = s[i];
            stringBuilder.Append(currentChar);
            while (i < s.Length && s[i] == currentChar)
            {
                i++;
            }
        }
        return stringBuilder.ToString();
    }
}