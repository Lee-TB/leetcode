namespace _1590._Make_Sum_Divisible_by_P.Tests;

public class SolutionUnitTests
{
    private Solution sln;
    public SolutionUnitTests()
    {
        sln = new Solution();
    }

    [Theory]
    [InlineData(new int[] { 3, 1, 4, 2 }, 6, 1)]
    [InlineData(new int[] { 6, 3, 5, 2 }, 9, 2)]
    [InlineData(new int[] { 1, 2, 3 }, 3, 0)]
    public void MinSubarray_ShouldReturnCorrectResult(int[] nums, int p, int expected)
    {
        var actual = sln.MinSubarray(nums, p);
        Assert.Equal(expected, actual);
    }
}