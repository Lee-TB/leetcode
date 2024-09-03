using System.Text;

var sln = new Solution();
string s = "zbax";
int k = 2;
Console.WriteLine(sln.GetLucky(s, k));

public class Solution
{
    public int GetLucky(string s, int k)
    {
        int lucky = 0;
        StringBuilder sb = new StringBuilder();
        // convert string to string of number with a is 1 (ex: "leetcode" ➝ "(12)(5)(5)(20)(3)(15)(4)(5)")
        foreach (char c in s)
        {
            int num = (int)c + 1 - (int)'a';
            sb.Append(num);
        }
        
        // now transform by sum every single digits
        while(k >= 1)
        {
            lucky = 0;
            foreach (char c in sb.ToString())
            {                
                lucky += c - '0';
            }
            sb.Clear();
            sb.Append(lucky.ToString());
            k--;
        }            
        return lucky;
    }
}