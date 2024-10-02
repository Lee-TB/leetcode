namespace _1331._Rank_Transform_of_an_Array.Tests;

public class LinqSolutionUnitTests
{
    private LinqSolution _sln;
    public LinqSolutionUnitTests()
    {
        _sln = new LinqSolution();
    }

    [Theory]
    [InlineData(new int[] { 40, 10, 20, 30 }, new int[] { 4, 1, 2, 3 })]
    [InlineData(new int[] { 100, 100, 100 }, new int[] { 1, 1, 1 })]
    [InlineData(new int[] { 37, 12, 28, 9, 100, 56, 80, 5, 12 }, new int[] { 5, 3, 4, 2, 8, 6, 7, 1, 3 })]
    public void ArrayRankTransform_ShouldReturnCorrectRanks(int[] arr, int[] expected)
    {
        // Act
        var actual = _sln.ArrayRankTransform(arr);

        // Assert
        Assert.Equal(expected, actual);
    }
}