namespace _1813._Sentence_Similarity_III;

public class Solution
{
    public bool AreSentencesSimilar_List(string sentence1, string sentence2)
    {
        List<string> splitted1 = sentence1.Split(' ').ToList();
        List<string> splitted2 = sentence2.Split(' ').ToList();

        while (splitted1.Count > 0 && splitted2.Count > 0 && splitted1.First() == splitted2.First())
        {
            splitted1.RemoveAt(0);
            splitted2.RemoveAt(0);
        }

        while (splitted1.Count > 0 && splitted2.Count > 0 && splitted1.Last() == splitted2.Last())
        {
            splitted1.RemoveAt(splitted1.Count - 1);
            splitted2.RemoveAt(splitted2.Count - 1);
        }

        return splitted1.Count == 0 || splitted2.Count == 0;
    }

    public bool AreSentencesSimilar_Array(string sentence1, string sentence2)
    {
        string[] splitted1 = sentence1.Split(' ');
        string[] splitted2 = sentence2.Split(' ');

        int count = 0;
        int i = 0, j = 0;

        while (i < splitted1.Length && i < splitted2.Length && splitted1[i] == splitted2[i])
        {
            i++;
            count++;
        }

        if (splitted1.Length == count || splitted2.Length == count) return true;

        while (j < splitted1.Length && j < splitted2.Length && splitted1[splitted1.Length - j - 1] == splitted2[splitted2.Length - j - 1])
        {
            j++;
            count++;
        }

        return splitted1.Length == count || splitted2.Length == count;
    }
}
