using _2491._Divide_Players_Into_Teams_of_Equal_Skilll;

namespace _2491._Divide_Players_Into_Teams_of_Equal_Skill.Tests;

public class SolutionUnitTests
{
    private Solution sln = new Solution();

    [Theory]    
    [InlineData(new int[] { 2, 2, 2, 2}, 8)]
    [InlineData(new int[] { 3, 2, 5, 1, 3, 4}, 22)]
    [InlineData(new int[] { 3, 4}, 12)]
    [InlineData(new int[] { 1, 1, 2, 3}, -1)]
    public void DividePlayers_ShouldReturnCorrectValue(int[] skill, long expected)
    {
        var actual = sln.DividePlayers(skill);
        Assert.Equal(expected, actual);
    }
}