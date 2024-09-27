namespace _731._My_Calendar_II;

public class MyCalendarTwo
{
    private List<(int start, int end)> bookedEvents;
    private List<(int start, int end)> overlapEvents;

    public MyCalendarTwo()
    {
        bookedEvents = new();
        overlapEvents = new();
    }

    public bool Book(int start, int end)
    {       
        foreach (var overlap in overlapEvents)
        {
            if(IsOverlap(overlap, (start, end)))
            {
                return false;
            }
        }

        foreach (var bookedEvent in bookedEvents)
        {
            if (IsOverlap(bookedEvent, (start, end)))
            {
                var overlap = GetOverlapped(bookedEvent, (start, end));
                overlapEvents.Add(overlap);
            }
        }

        bookedEvents.Add((start, end));
        return true;
    }

    private (int start, int end) GetOverlapped((int start, int end) event1, (int start, int end) event2)
    {
        return (Math.Max(event1.start, event2.start), Math.Min(event1.end, event2.end));
    }

    private bool IsOverlap((int start, int end) event1, (int start, int end) event2)
    {
        return Math.Max(event1.start, event2.start) < Math.Min(event1.end, event2.end);
    }
}