public class Solution
{
    public int CountDays(int days, int[][] meetings)
    {

        List<int> meetingStartDays = new List<int>();
        List<int> meetingEndDays = new List<int>();
        HashSet<int> meetingDays = new HashSet<int>();
        int output = 0;

        for (int i = 0; i < meetings.Length; i++)
        {
            meetingStartDays.Add(meetings[i][0]);
            meetingEndDays.Add(meetings[i][1]);

            for (int j = meetings[i][0]; j <= meetings[i][1]; j++)
            {
                meetingDays.Add(j);
            }
        }

        for (int i = 1; i <= days; i++)
        {
            int startIndex = meetingStartDays.IndexOf(i);

            Console.WriteLine("" + i);

            if (startIndex != -1)
            {
                i = meetingEndDays[startIndex];
            }


            if (!meetingDays.Contains(i))
                output++;
        }

        return output;
    }
}