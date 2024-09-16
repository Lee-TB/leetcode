string[] timePoints = ["00:00", "04:00", "22:00"];
var sln = new Solution();
Console.WriteLine(sln.FindMinDifference(timePoints));
//Console.WriteLine(sln.TimePointToMinutes("23:59"));
public class Solution
{
    public int FindMinDifference(IList<string> timePoints)
    {
        int day = 24 * 60;
        int n = timePoints.Count;
        int[] minutes = new int[n];

        for (int i = 0; i < n; i++)
        {
            minutes[i] = TimePointToMinutes(timePoints[i]);
        }
        Array.Sort(minutes);

        int minDiff = day;
        for (int i = 1; i < n; i++)
        {
            minDiff = Math.Min(minutes[i] - minutes[i - 1], minDiff);
        }

        minDiff = Math.Min(minDiff, day + minutes[0] - minutes[n - 1]); // min diff beetween first and last "00:00" + "24:00" and "22:00"

        return minDiff;
    }

    public int TimePointToMinutes(string timePoint)
    {
        int hours = Int32.Parse(timePoint.Substring(0, 2));
        int minutes = Int32.Parse(timePoint.Substring(timePoint.Length - 2, 2));
        int totalMinutes = (hours * 60) + minutes;
        return totalMinutes;
    }
}