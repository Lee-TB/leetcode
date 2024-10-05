
namespace _567._Permutation_in_String;

public class Solution
{
    public bool CheckInclusion(string s1, string s2)
    {
        s1 = SortString(s1);
        bool isSubstring = false;
        for (int i = 0; i <= s2.Length - s1.Length; i++)
        {
            string substring = s2.Substring(i, s1.Length);
            substring = SortString(substring);
            if(s1.Equals(substring))
            {
                isSubstring = true;
                break;
            }
        }

        return isSubstring;
    }

    private string SortString(string s1)
    {
        char[] chars = s1.ToCharArray();
        Array.Sort(chars);
        return new string(chars);
    }
}