var sln = new Solution();
string allowed = "abc";
string[] words = ["a", "b", "c", "ab", "ac", "bc", "abc"];
Console.WriteLine(sln.CountConsistentStrings(allowed, words));
public class Solution
{
    public int CountConsistentStrings(string allowed, string[] words)
    {
        int count = 0;
        foreach (string word in words)
        {
            count++;
            foreach (char c in word)
            {
                if (!allowed.Contains(c))
                {
                    count--;
                    break;
                }
            }
        }
        return count;
    }
}