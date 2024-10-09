namespace _921._Minimum_Add_to_Make_Parentheses_Valid;

public class Solution
{
    public int MinAddToMakeValid(string s)
    {
        int openCount = 0;
        int closeCount = 0;
        foreach (char c in s) {
            if (c == '(') { openCount++; } 
            else if(c == ')') {
                if (openCount > 0) { 
                    openCount--;
                } else
                {
                    closeCount++; 
                }
            }
        }
        return openCount + closeCount;
    }
}
