var sln = new Solution();
string s1 = "this apple is sweet";
string s2 = "this apple is sour";
string[] words = sln.UncommonFromSentences(s1, s2);
foreach (var word in words)
{
    Console.WriteLine(word);
}

public class Solution
{
    public string[] UncommonFromSentences(string s1, string s2)
    {
        string[] words = (s1 + " " + s2).Split(" ");
        var group = words.GroupBy(w => w);
        var uncommonWords = group.Where((g) => g.Count() == 1).Select(g => g.Key);
        return uncommonWords.ToArray();
    }
}