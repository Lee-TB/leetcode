var sln = new Solution();
Console.WriteLine(sln.MinSteps(6));
public class Solution
{
    public int MinSteps(int n)
    {
        if(n == 1) return 0;
        return 1 + MinStepsHelper(n, 1, 1); // first step is copy
    }

    private int MinStepsHelper(int n, int curLen, int pasteLen)
    {
        if(curLen == n) return 0;
        if (curLen > n) return 1000; // big number represent for infinity number

        // we have 2 scenarios:
        // copy all + paste
        int opt1 = 2 + MinStepsHelper(n, curLen * 2, curLen);
        // paste current copy
        int opt2 = 1 + MinStepsHelper(n, curLen + pasteLen, pasteLen);

        return Math.Min(opt1, opt2);
    }
}