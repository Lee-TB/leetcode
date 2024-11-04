using System.Text;
namespace _3163._String_Compression_III;

public class Solution
{
    public string CompressedString(string word)
    {
        StringBuilder sb = new StringBuilder();
        char currentChar = word[0];
        int times = 0;
        foreach (char c in word)
        {
            if (currentChar == c)
            {
                times++;
                if (times == 9)
                {
                    sb.Append(times);
                    sb.Append(currentChar);
                    times = 0;
                }
            }
            else
            {
                if(times !=0 )
                {
                    sb.Append(times);
                    sb.Append(currentChar);
                }
                times = 1;
                currentChar = c;
            }
        }

        if (times != 0)
        {
            sb.Append(times);
            sb.Append(currentChar);
        }
        return sb.ToString();
    }
}
