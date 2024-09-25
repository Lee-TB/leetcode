namespace _2416._Sum_of_Prefix_Scores_of_Strings.Tests;

public class SolutionUnitTests
{
    private readonly Solution _solution;
    public SolutionUnitTests()
    {
        _solution = new Solution();
    }

    [Theory]
    [InlineData(new string[] { "abc", "ab", "bc", "b" }, new int[] { 5, 4, 3, 2 })]
    [InlineData(new string[] { "abcd" }, new int[] { 4 })]
    public void SumPrefixScores_WordsArray_ReturnCorrectResult(string[] words, int[] expected)
    {
        // Act
        var actual = _solution.SumPrefixScores(words);

        // Assert
        Assert.Equal(expected, actual);
    }

    [Fact]
    public void SumPrefixScores_EmtyWordsArray_ReturnEmtyArray()
    {
        // Arrange
        string[] words = [];
        int[] expected = [];

        // Act
        var actual = _solution.SumPrefixScores(words);

        // Assert
        Assert.Equal(expected, actual);
    }
}