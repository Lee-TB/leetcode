namespace _1768._Merge_Strings_Alternately.Tests;

public class SolutionUnitTests
{
    [Theory]
    [InlineData("abc", "pqr", "apbqcr")]
    [InlineData("ab", "pqrs", "apbqrs")]
    [InlineData("abcd", "pq", "apbqcd")]
    public void MergeAlternately_ShouldReturnCorrectValue(string word1, string word2, string expected)
    {
        var sln = new Solution();
        var actual = sln.MergeAlternately(word1, word2);
        Assert.Equal(expected, actual);
    }
}