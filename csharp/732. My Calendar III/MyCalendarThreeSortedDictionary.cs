namespace _732._My_Calendar_III;

public class MyCalendarThreeSortedDictionary
{
    private readonly SortedDictionary<int, int> timeline = new SortedDictionary<int, int>();

    public int Book(int startTime, int endTime)
    {
        timeline[startTime] = timeline.GetValueOrDefault(startTime, 0) + 1;
        timeline[endTime] = timeline.GetValueOrDefault(endTime, 0) - 1;
        int max = 0, k = 0;
        foreach (var (key, value) in timeline)
        {
            max = Math.Max(max, k += value);
        }
        return max;
    }
}