var sln = new Solution();
int res = sln.MinBitFlips(10, 7);
Console.WriteLine(res);
public class Solution
{
    public int MinBitFlips(int start, int goal)
    {
        int diffBit = start ^ goal; // 1010 ^ 0111 = 1101
        int count = 0;
        while (diffBit > 0)
        {
            if ((diffBit & 1) == 1) count++; // 1101 & 0001 = 0001 = 1
            diffBit = diffBit >> 1;
        }
        return count;
    }

    public int MinBitFlips_OldSolution(int start, int goal)
    {
        string startBitString = Convert.ToString(start, toBase: 2);
        string goalBitString = Convert.ToString(goal, toBase: 2);

        int len = startBitString.Length > goalBitString.Length ? startBitString.Length : goalBitString.Length;
        if (startBitString.Length < len)
        {
            startBitString = String.Concat(Enumerable.Repeat('0', len - startBitString.Length)) + startBitString;
        }
        if (goalBitString.Length < len)
        {
            goalBitString = String.Concat(Enumerable.Repeat('0', len - goalBitString.Length)) + goalBitString;
        }

        int countDiff = 0;

        for (int i = 0; i < len; i++) {
            if (startBitString[i] != goalBitString[i]) countDiff++;           
        }
        
        return countDiff;
    }
}