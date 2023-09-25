namespace _389._Find_the_Difference;

internal class Program
{
    static void Main(string[] args)
    {
        Console.WriteLine(FindTheDifference("avx", "asvx"));
    }

    public static char FindTheDifference_Simple(string s, string t)
    {
        int result = 0;

        foreach (char c in t) result += c;

        foreach (char c in s) result -= c;

        return (char)result;
    }

    public static char FindTheDifference(string s, string t)
    {   
        Dictionary<char, int> map = new Dictionary<char, int>();

        for (int i = 0; i < t.Length; i++)
        {
            if (map.ContainsKey(t[i]))
            {
                map[t[i]]++;
            }
            else
            {
                map[t[i]] = 1;
            }
        }

        for (int i = 0; i < s.Length; i++)
        {
            if (map.ContainsKey(s[i]))
            {
                map[s[i]]--;
            }
        }

        foreach (char key in map.Keys) {
            if (map[key] == 1)
            {
                return key;
            }
        }

        return 'N';

    }
}