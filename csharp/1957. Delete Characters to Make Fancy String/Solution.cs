using System.Text;

namespace _1957._Delete_Characters_to_Make_Fancy_String;

public class Solution
{
    public string MakeFancyString(string s)
    {
        StringBuilder sb = new StringBuilder();
        char prevChar = s[0];
        int count = 0;
        foreach (char c in s)
        {
            if (c == prevChar)
            {
                count++;
            } else
            {
                count = 1;
            }

            if(count <= 2)
            {
                sb.Append(c);                        
            }
            prevChar = c;
        }
        return sb.ToString();
    }
}
