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
        var wordList = new List<string>(s.Split(' '));
        for (int i = 0; i < wordList.Count; i++)
        {
            char[] charArray = wordList[i].ToCharArray();
            Array.Reverse(charArray);
            wordList[i] = new string(charArray);
        }
        return string.Join(' ', wordList);
    }

}