using System.Text;

var sln = new Solution2();
int[] arr1 = [3, 26, 1234];
int[] arr2 = [7, 16, 123];

var len = sln.LongestCommonPrefix(arr1, arr2);
Console.WriteLine(len);

class Solution
{
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        int maxLen = 0;
        HashSet<int> hashSet = new HashSet<int>();
        foreach (int num in arr1)
        {
            int subNum = num;
            while (subNum > 0)
            {
                hashSet.Add(subNum);
                subNum /= 10;
            }
        }

        foreach (int num in arr2)
        {
            int subNum = num;
            while (subNum != 0)
            {
                if (hashSet.Contains(subNum))
                {
                    maxLen = Math.Max(subNum.ToString().Length, maxLen);
                    break;
                }
                subNum /= 10;
            }
        }

        return maxLen;
    }
}

class Solution2
{
    public int LongestCommonPrefix(int[] arr1, int[] arr2)
    {
        Trie trie = new Trie();
        foreach (int num in arr1)
        {
            trie.Insert(num);
        }

        int maxLen = 0;
        foreach (int num in arr2)
        {
            int len = trie.LongestPrefix(num);
            maxLen = Math.Max(maxLen, len);
        }

        return maxLen;
    }
}

class TrieNode
{
    public TrieNode[] Children = new TrieNode[10];
}

class Trie
{
    TrieNode root = new TrieNode();

    public void Insert(int number)
    {
        TrieNode node = root;
        string numStr = number.ToString();
        foreach (char digit in numStr)
        {
            int index = digit - '0';
            if (node.Children[index] == null)
            {
                node.Children[index] = new TrieNode();
            }
            node = node.Children[index];
        }
    }

    public int LongestPrefix(int number)
    {
        TrieNode node = root;
        string numStr = number.ToString();
        int len = 0;
        foreach (char digit in numStr)
        {
            int index = digit - '0';
            if (node.Children[index] != null)
            {
                len++;
                node = node.Children[index];
            }
            else break;
        }
        return len;
    }
}