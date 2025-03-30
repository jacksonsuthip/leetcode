public class Solution
{
    public IList<int> PartitionLabels(string s)
    {
        List<int> output = new List<int>();
        int lastSIndex = 0;
        //string partString = "";
        StringBuilder partStringBuilder = new StringBuilder();

        for (int i = 0; i < s.Length; i++)
        {
            int currentLastSIndex = s.LastIndexOf(s[i]);

            // partString = partString + s[i];
            partStringBuilder.Append(s[i]);

            if (lastSIndex < currentLastSIndex)
            {
                lastSIndex = currentLastSIndex;
            }

            if (i == lastSIndex)
            {
                lastSIndex = 0;
                // output.Add(partString.Length);
                // partString = "";
                output.Add(partStringBuilder.Length);
                partStringBuilder.Clear();
            }
        }

        return output;
    }
}