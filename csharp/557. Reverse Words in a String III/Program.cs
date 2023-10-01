/*  557. Reverse Words in a String III
    Given a string s, reverse the order of characters in each word within a sentence while still preserving whitespace and initial word order.
    Input: s = "Let's take LeetCode contest" 
    Output: "s'teL ekat edoCteeL tsetnoc"
 */

namespace _557._Reverse_Words_in_a_String_III;

internal class Solution
{
    static void Main(string[] args)
    {
        string s = "Let's take LeetCode contest";
        Console.WriteLine(ReverseWords(s));
    }


    public static string ReverseWords(string s)
    {
        var listString = new List<string>(s.Split(' '));
        for (int i = 0; i < listString.Count; i++)
        {
            char[] charArray = listString[i].ToCharArray();
            Array.Reverse(charArray);
            listString[i] = new string(charArray);
        }
        return string.Join(" ", listString);
    }

}