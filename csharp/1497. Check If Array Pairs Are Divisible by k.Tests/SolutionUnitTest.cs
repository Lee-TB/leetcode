namespace _1497._Check_If_Array_Pairs_Are_Divisible_by_k.Tests;

public class SolutionUnitTest
{
    [Theory]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 10, 6, 7, 8, 9 }, 5)]
    [InlineData(new int[] { 1, 2, 3, 4, 5, 6 }, 7)]
    public void CanArrange_ShouldReturnTrue(int[] arr, int k)
    {
        var sln = new Solution();

        var actual = sln.CanArrange(arr, k);

        Assert.True(actual);
    }

    [Fact]
    public void CanNotArrange_ShouldReturnFalse()
    {
        var sln = new Solution();
        int[] arr = [1, 2, 3, 4, 5, 6];
        int k = 10;

        var actual = sln.CanArrange(arr, k);

        Assert.False(actual);
    }
}