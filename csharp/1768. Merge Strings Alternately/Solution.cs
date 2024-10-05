using System.Text;

namespace _1768._Merge_Strings_Alternately;

public class Solution
{
    public string MergeAlternately(string word1, string word2)
    {
        StringBuilder merged = new StringBuilder();
        for (int i = 0; i < word1.Length || i < word2.Length; i++)
        {
            if (i < word1.Length) merged.Append(word1[i]);
            if (i < word2.Length) merged.Append(word2[i]);
        }
        return merged.ToString();
    }
}
