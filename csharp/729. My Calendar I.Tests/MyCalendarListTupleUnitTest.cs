using FluentAssertions;

namespace _729._My_Calendar_I.Tests;

public class MyCalendarListTupleUnitTest
{
    [Fact]
    public void Book_CanBeBooked_ReturnTrue()
    {
        // arrange 
        MyCalendarListTuple calendar = new MyCalendarListTuple();

        // act
        var actual = calendar.Book(10, 20);

        // assert
        Assert.True(actual);
    }

    [Fact]
    public void Book_CannotBeBooked_ReturnFalse()
    {
        MyCalendarListTuple calendar = new MyCalendarListTuple();

        // act
        calendar.Book(10, 20);
        var actual = calendar.Book(15, 25);

        // assert
        Assert.False(actual);
    }

    [Fact]
    public void Book_VariousInput_ShouldEqualExpected()
    {
        // arrange 
        int[][] input = [[47, 50], [33, 41], [39, 45], [33, 42], [25, 32], [26, 35], [19, 25], [3, 8], [8, 13], [18, 27]];
        bool[] expected = [true, true, false, false, true, false, true, true, true, false];
        MyCalendarListTuple calendar = new MyCalendarListTuple();

        for (int i = 0; i < input.Length; i++)
        {
            // act
            var actual = calendar.Book(input[i][0], input[i][1]);

            // assert      
            actual.Should().Be(expected[i]);
        }
    }
}
