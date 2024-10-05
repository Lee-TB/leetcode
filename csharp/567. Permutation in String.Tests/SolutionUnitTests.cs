namespace _567._Permutation_in_String.Tests;

public class SolutionUnitTests
{
    private Solution sln = new Solution();
    [Theory]
    [InlineData("ab", "eidbaooo", true)]
    [InlineData("ab", "eidboaoo", false)]
    public void CheckInclusion_ShouldEqualExpected(string s1, string s2, bool expected)
    {
        var actual = sln.CheckInclusion(s1, s2);
        Assert.Equal(expected, actual);
    }
}