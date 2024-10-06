namespace _1813._Sentence_Similarity_III.Tests;

public class SolutionUnitTests
{
    private Solution sln = new Solution();

    [Theory]
    [InlineData("My name is Haley", "My Haley", true)]
    [InlineData("of", "A lot of words", false)]
    [InlineData("Eating right now", "Eating", true)]
    public void AreSentencesSimilar_List_ShouldReturnCorrectValue(string sentence1, string sentence2, bool expected)
    {
        // Act
        bool actual = sln.AreSentencesSimilar_List(sentence1, sentence2);
        // Assert
        Assert.Equal(expected, actual);
    }

    [Theory]
    [InlineData("My name is Haley", "My Haley", true)]
    [InlineData("of", "A lot of words", false)]
    [InlineData("Eating right now", "Eating", true)]
    [InlineData("Ogn WtWj HneS", "Ogn WtWj HneS", true)]
    public void AreSentencesSimilar_Array_ShouldReturnCorrectValue(string sentence1, string sentence2, bool expected)
    {
        // Act
        bool actual = sln.AreSentencesSimilar_Array(sentence1, sentence2);
        // Assert
        Assert.Equal(expected, actual);
    }
}