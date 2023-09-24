// Given two strings s and t, return true if s is a subsequence of t, or false otherwise.
namespace _392._Is_Subsequence;
internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(IsSubsequence("ace", "abcde"));
        
    }
    public static bool IsSubsequence(string s, string t)
    {
        if (s.Length == 0) return true;       

        if (s.Length > t.Length) return false;

        int index = t.IndexOf(s[0]);
        if ( t.IndexOf(s[0]) == -1) return false;        

        return IsSubsequence(s.Substring(1), t.Substring(index + 1));        
    }
}