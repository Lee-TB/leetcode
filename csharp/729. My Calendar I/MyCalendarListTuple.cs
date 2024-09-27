namespace _729._My_Calendar_I;

public class MyCalendarListTuple
{
    private readonly List<(int start, int end)> bookings;

    public MyCalendarListTuple()
    {
        bookings = new();
    }

    public bool Book(int start, int end)
    {
        foreach (var booked in bookings) {
            if (IsOverlapped(booked, (start, end)))
            {
                return false;
            }
        }
        bookings.Add((start, end));
        return true;
    }

    private bool IsOverlapped((int start, int end) event1, (int start, int end) event2)
    {
        return Math.Max(event1.start, event2.start) < Math.Min(event1.end, event2.end);
    }
}
