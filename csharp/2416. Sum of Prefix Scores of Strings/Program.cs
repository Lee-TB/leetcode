var sln = new Solution();
string[] words = ["aa", "abc", "ab", "bc", "b"];
sln.SumPrefixScores(words);
public class Solution
{
    public int[] SumPrefixScores(string[] words)
    {
        int n = words.Length;
        int[] sumArray = new int[n];
        Trie trie = new Trie();

        for (int i = 0; i < n; i++)
        {
            trie.Insert(words[i]);
        }

        for (int i = 0; i < n; i++)
        {
            sumArray[i] = trie.CountPrefix(words[i]);             
        }

        return sumArray;
    }
}

public class TrieNode
{
    public TrieNode[] Children = new TrieNode[26];
    public int Count = 0;
}

public class Trie
{
    private TrieNode root = new TrieNode();

    public void Insert(string word)
    {
        TrieNode node = root;
        foreach (char c in word)
        {
            int index = c - 'a';
            if (node.Children[index] == null)
            {                
                node.Children[index] = new TrieNode();
            }
            node.Children[index].Count++;
            node = node.Children[index];
        }
    }

    public int CountPrefix(string word) 
    {
        int count = 0;
        TrieNode node = root;
        foreach (char c in word)
        {
            int index = c - 'a';
            if (node.Children[index] != null)
            {
                count += node.Children[index].Count;
                node = node.Children[index];
            }
            else break;
        }
        return count;
    }
}