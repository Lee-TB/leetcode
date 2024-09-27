namespace _731._My_Calendar_II.Tests;

public class MyCalendarTwoUnitTest
{
    [Fact]
    public void Book_CanBeBooked_ShouldReturnTrue()
    {
        // Arrange 
        MyCalendarTwo calendar = new MyCalendarTwo();
        int[] book = [10, 20];
        bool expected = true;

        // Act
        bool actual = calendar.Book(book[0], book[1]);

        // Assert
        Assert.Equal(expected, actual);

    }

    [Fact]
    public void Book_VariousInput_ShouldEqualExpected()
    {
        // Arrange 
        MyCalendarTwo calendar = new MyCalendarTwo();
        int[][] books = [[10, 20], [50, 60], [10, 40], [5, 15], [5, 10], [25, 55]];
        bool[] expected = [true, true, true, false, true, true];

        // Act
        for (int i = 0; i < books.Length; i++)
        {
            bool actual = calendar.Book(books[i][0], books[i][1]);
            // Assert
            Assert.Equal(expected[i], actual);
        }
    }
}