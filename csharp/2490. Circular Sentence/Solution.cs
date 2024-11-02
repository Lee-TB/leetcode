namespace _2490._Circular_Sentence;

public class Solution
{
    public bool IsCircularSentence(string sentence)
    {
        var words = sentence.Split(" ");

        // check beetween two adjacent words
        for (int i = 1; i < words.Length; i++)
        {
            var prevWord = words[i - 1];
            var currWord = words[i];
            if (prevWord[prevWord.Length - 1] != currWord[0])
            {
                return false;
            }
        }

        // check first and last words
        var firstWord = words[0];
        var lastWord = words[words.Length - 1];
        if (firstWord[0] != lastWord[lastWord.Length - 1])
        {
            return false;
        }

        return true;
    }
}