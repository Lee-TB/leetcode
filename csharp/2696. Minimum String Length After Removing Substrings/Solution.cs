namespace _2696._Minimum_String_Length_After_Removing_Substrings;

public class Solution
{
    public int MinLength(string s)
    {
        while (s.Contains("AB") || s.Contains("CD")) {            
            if(s.Contains("AB"))
            {
                s = s.Replace("AB", "");
            }
            if(s.Contains("CD"))
            {
                s = s.Replace("CD", "");
            }
        }
        return s.Length;
    }
}
