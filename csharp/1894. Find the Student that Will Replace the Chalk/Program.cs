var sln = new Solution();
int[] chalk = [5, 1, 5];
int k = 22;
Console.WriteLine(sln.ChalkReplacer(chalk, k));

public class Solution
{
    public int ChalkReplacer(int[] chalk, int k)
    {
        long sumChalk = 0;
        foreach (var c in chalk)
        {
            sumChalk += c;
        }
        int moduloChalk = (int)(k % sumChalk); // find minimum Chalk need to use to reduce time

        int i = 0;
        while (moduloChalk >= chalk[i])
        {
            moduloChalk -= chalk[i];
            i++;
            if (i >= chalk.Length) i = 0;
        }
        return i;
    }
}