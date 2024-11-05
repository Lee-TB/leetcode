namespace _2914._Minimum_Number_of_Changes_to_Make_Binary_String_Beautiful;

public class Solution
{
    public int MinChanges(string s)
    {
        int minChanges = 0;
        int count = 0;
        char currentChar = s[0];
        foreach (char c in s)
        {
            if(c == currentChar)
            {
                count++;
                continue;
            }

            if (count % 2 == 0) { 
                count = 1;
            } else
            {
                minChanges++;
                count++;
            }

            currentChar = c;
        }

        return minChanges;
    }
}
