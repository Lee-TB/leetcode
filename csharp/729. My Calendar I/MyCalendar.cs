namespace _729._My_Calendar_I;

public class MyCalendar
{
    private readonly List<int[]> _list;

    public MyCalendar()
    {
        _list = new List<int[]>();
    }

    public bool Book(int start, int end)
    {
        if (start >= end) return false;

        if (_list.Count == 0)
        {
            _list.Add(new int[] { start, end });
        }
        else
        {
            if (_list.Any(pair => start < pair[1] && end > pair[0]))
            {
                return false;
            }

            int index = _list.FindIndex(pair => start >= pair[1]);
            if (index == -1)
            {
                index = _list.FindLastIndex(pair => end <= pair[0]);
            }

            if (index != -1)
            {
                _list.Insert(index, new int[] { start, end });
            }
        }

        return true;
    }
}
