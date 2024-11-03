namespace _796._Rotate_String;

public class Solution
{
    public bool RotateString(string s, string goal)
    {
        if(s.Length != goal.Length) return false;
        string concatenatedString = s + s;
        return concatenatedString.Contains(goal);
    }
}
