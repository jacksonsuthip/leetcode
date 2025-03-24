// AI DeepSeek

public class Solution
{
    public int CountDays(int days, int[][] meetings)
    {
        // Sort meetings by start day
        Array.Sort(meetings, (a, b) => a[0].CompareTo(b[0]));

        int freeDays = 0;
        int lastCoveredDay = 0;

        foreach (var meeting in meetings)
        {
            int start = meeting[0];
            int end = meeting[1];

            // Add days before this meeting starts (if any)
            if (start > lastCoveredDay + 1)
            {
                freeDays += start - (lastCoveredDay + 1);
            }

            // Update the last covered day
            if (end > lastCoveredDay)
            {
                lastCoveredDay = end;
            }
        }

        // Add remaining days after all meetings
        if (lastCoveredDay < days)
        {
            freeDays += days - lastCoveredDay;
        }

        return freeDays;
    }
}