using System.Text;

namespace _3._Longest_Substring_Without_Repeating_Characters;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(LengthOfLongestSubstring("abccbcbb"));
    }
    public static int LengthOfLongestSubstring(string s)
    {
        StringBuilder substring = new StringBuilder();
        int longestLength = 0;

        foreach (var c in s)
        {
            int charRepeatIndex = substring.ToString().IndexOf(c);
            if (charRepeatIndex != -1)
            {                
                substring = new StringBuilder(substring.ToString().Substring(charRepeatIndex + 1));
            }
 
            substring.Append(c);
            longestLength = Math.Max(substring.Length, longestLength);
        }

        return longestLength;
    }
}