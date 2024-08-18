var sln = new Solution();
Console.WriteLine(sln.NthUglyNumber(1690));

public class Solution
{
    public int NthUglyNumber(int n)
    {
        HashSet<long> set = new() { 1 };
        long currentUgly = 1;

        for (int i = 0; i < n; i++)
        {
            currentUgly = set.Min();
            set.Remove(currentUgly);
            set.Add(currentUgly * 2);
            set.Add(currentUgly * 3);
            set.Add(currentUgly * 5);            
        }
        
        return (int)currentUgly;
    }
}