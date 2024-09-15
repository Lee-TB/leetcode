// 1. count all vowels and store to an hashmap like data types
// 2. determine where to slice string into substring

var sln = new Solution();
int cur = 0;
Console.WriteLine(1 << (4));
int len = sln.FindTheLongestSubstring("iibicbcbc");
Console.WriteLine("len " + len);

public class Solution
{
    public int FindTheLongestSubstring(string s)
    {
        int res = 0, cur = 0, n = s.Length;
        Dictionary<int, int> seen = new Dictionary<int, int>();
        seen.Add(0, -1);
        for (int i = 0; i < n; i++)
        {
            cur ^= 1 << ("aeiou".IndexOf(s[i]) + 1) >> 1;
            if (!seen.ContainsKey(cur))
            {
                seen.Add(cur, i);
            }
            Console.WriteLine("i=" + i + " cur=" + cur + " seen[cur]=" + seen[cur] + " i - seen[cur]=" + (i - seen[cur]));
            res = Math.Max(res, i - seen[cur]);
        }
        return res;
    }

    public string SliceUntilAllEvenVowels(string s)
    {
        Dictionary<char, int> vowels = CountAppearNumber(s);

        if (vowels.All(vowel => vowel.Value % 2 == 0)) return s; // all all vowels is even cout return value;

        int subStart = 0;
        int subLen = s.Length;
        string substring = s;

        foreach (KeyValuePair<char, int> vowel in vowels)
        {
            if (vowel.Value % 2 != 0)
            {
                int firstIndex = s.IndexOf(vowel.Key);
                int firstLen = 1 + firstIndex - 0;

                int lastIndex = s.LastIndexOf(vowel.Key);
                int lastLen = s.Length - lastIndex;

                // between first or last we will cut for longest substring               
                if (lastLen < firstLen)
                {
                    subStart = 0;
                    subLen = lastIndex;
                }
                else
                {
                    subStart = firstIndex + 1;
                    subLen = s.Length - subStart;
                }

                // between odd vowels we will cut for shortest substring
                string cutstring = s.Substring(subStart, subLen);
                if (cutstring.Length < substring.Length)
                {
                    substring = cutstring;
                }

                //Console.WriteLine(vowel.Key + " first index: " + s.IndexOf(vowel.Key) + " last index: " + s.LastIndexOf(vowel.Key) + " firstlen: " + firstLen  + " lastlen: " + lastLen);
                //Console.WriteLine("cutStart "+ subStart+ " cutLen "+ subLen);
            }
            //Console.WriteLine($"{vowel.Key} {vowel.Value}");
        }
        Console.WriteLine("substring " + substring);

        return SliceUntilAllEvenVowels(substring);
    }

    private static Dictionary<char, int> CountAppearNumber(string s)
    {
        Dictionary<char, int> vowels = new Dictionary<char, int>()
        {
            {'a', 0},
            {'e', 0},
            {'i', 0},
            {'o', 0},
            {'u', 0},
        };

        foreach (char c in s)
        {
            if (vowels.ContainsKey(c))
            {
                vowels[c] += 1;
            }
        }

        return vowels;
    }
}