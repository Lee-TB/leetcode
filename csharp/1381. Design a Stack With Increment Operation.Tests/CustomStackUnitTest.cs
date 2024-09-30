namespace _1381._Design_a_Stack_With_Increment_Operation.Tests;

public class CustomStackUnitTest
{
    [Fact]
    public void Pop_WhenStackIsEmpty_ShouldReturnMinusOne()
    {
        var stack = new CustomStack(3);
        var actual = stack.Pop();
        Assert.Equal(-1, actual);
    }

    [Fact]
    public void Pop_WhenStackIsNotEmpty_ShouldFollowLastInFirstOut()
    {
        var stack = new CustomStack(3);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);            
        Assert.Equal(3, stack.Pop());
        Assert.Equal(2, stack.Pop());
        Assert.Equal(1, stack.Pop());
    }

    [Fact]
    public void Push_AfterPopOperations_ShouldAddAndReturnCorrectValues()
    {
        var stack = new CustomStack(3);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Pop();
        stack.Pop();
        stack.Push(4);
        stack.Push(5);
        Assert.Equal(5, stack.Pop());
        Assert.Equal(4, stack.Pop());
        Assert.Equal(1, stack.Pop());
    }

    [Fact]
    public void Push_WhenStackIsFull_ShouldNotExceedStackSize()
    {
        var stack = new CustomStack(3);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);
        stack.Push(4);            
        Assert.Equal(3, stack.Count);
    }

    [Fact]
    public void Increment_WhenStackHasMoreThanKElements_ShouldIncrementBottomKElements()
    {
        // Arrange
        var stack = new CustomStack(5);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Act
        stack.Increment(2, 10); // Increment bottom 2 elements by 10

        // Assert
        Assert.Equal(3, stack.Pop());  // 3rd element unchanged (3) 
        Assert.Equal(12, stack.Pop());  // 2nd element (2 + 10)
        Assert.Equal(11, stack.Pop());  // Bottom element (1 + 10)
    }

    [Fact]
    public void Increment_WhenStackHasExactlyKElements_ShouldIncrementAllElements()
    {
        // Arrange
        var stack = new CustomStack(3);
        stack.Push(1);
        stack.Push(2);
        stack.Push(3);

        // Act
        stack.Increment(3, 5); // Increment all 3 elements by 5

        // Assert
        Assert.Equal(8, stack.Pop());  // 3 + 5
        Assert.Equal(7, stack.Pop());  // 2 + 5
        Assert.Equal(6, stack.Pop());  // 1 + 5
    }

    [Fact]
    public void Increment_WhenStackHasLessThanKElements_ShouldIncrementAllElements()
    {
        // Arrange
        var stack = new CustomStack(2);
        stack.Push(10);
        stack.Push(20);

        // Act
        stack.Increment(5, 3); // Attempt to increment 5 elements, but the stack has only 2

        // Assert
        Assert.Equal(23, stack.Pop());  // 20 + 3
        Assert.Equal(13, stack.Pop());  // 10 + 3
    }

}