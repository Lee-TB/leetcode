var sln = new Solution();
string s = "abcd";
var res = sln.ShortestPalindrome(s);
Console.WriteLine(res);

public class Solution
{
    public string ShortestPalindrome(string s)
    {
        string reversedString = Reverse(s);
        for (int i = s.Length; i > 0; i--)
        {
            string substring = s.Substring(0, i);
            string subReversedString = reversedString.Substring(s.Length - i, i);
            Console.WriteLine(substring + " " + subReversedString);
            if (substring == subReversedString)
            {
                string addingString = reversedString.Substring(0, s.Length - i);
                return addingString + s;
            }
        }
        return "";
    }

    public string ShortestPalindrome1(string s)
    {
        for (int i = s.Length; i > 0; i--)
        {
            string substring = s.Substring(0, i);
            if (IsPalindrome(substring)) // call Array.Reverse(chars) n times if not exists any Palindrome
            {
                string addingString = Reverse(s.Substring(i));
                return addingString + s;
            }
        }
        return "";
    }

    public static bool IsPalindrome(string s)
    {
        return s == Reverse(s);
    }

    public static string Reverse(string s)
    {
        char[] chars = s.ToCharArray();
        Array.Reverse(chars);
        return new string(chars);
    }
}