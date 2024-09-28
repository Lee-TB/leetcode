namespace _732._My_Calendar_III.Tests
{
    public class MyCalendarThreeSortedDictionaryUnitTest
    {
        [Fact]
        public void Book_VariousInputs_ShouldEqualExpected()
        {
            // Arrange
            int[][] bookings = [[10, 20], [50, 60], [10, 40], [5, 15], [5, 10], [25, 55]];
            int[] expected = [1, 1, 2, 3, 3, 3];
            MyCalendarThreeSortedDictionary calendarThree = new();

            // Act
            foreach (int i in Enumerable.Range(0, bookings.Length))
            {
                int actual = calendarThree.Book(bookings[i][0], bookings[i][1]);
                Assert.Equal(expected[i], actual);
            }
        }

        [Fact]
        public void Book_VariousInputs_ShouldEqualExpected_Test2()
        {
            // Arrange
            int[][] bookings = [[26, 35], [26, 32], [25, 32], [18, 26], [40, 45], [19, 26], [48, 50], [1, 6], [46, 50], [11, 18]];
            int[] expected = [1, 2, 3, 3, 3, 3, 3, 3, 3, 3];
            MyCalendarThreeSortedDictionary calendarThree = new();

            // Act
            foreach (int i in Enumerable.Range(0, bookings.Length))
            {
                int actual = calendarThree.Book(bookings[i][0], bookings[i][1]);
                Assert.Equal(expected[i], actual);
            }
        }

        [Fact]
        public void Book_VariousInputs_ShouldEqualExpected_Test3()
        {
            // Arrange
            int[][] bookings = [[24, 40], [43, 50], [27, 43], [5, 21], [30, 40], [14, 29], [3, 19], [3, 14], [25, 39], [6, 19]];
            int[] expected = [1, 1, 2, 2, 3, 3, 3, 3, 4, 4];
            MyCalendarThreeSortedDictionary calendarThree = new();

            // Act
            foreach (int i in Enumerable.Range(0, bookings.Length))
            {
                int actual = calendarThree.Book(bookings[i][0], bookings[i][1]);
                Assert.Equal(expected[i], actual);
            }
        }
    }
}