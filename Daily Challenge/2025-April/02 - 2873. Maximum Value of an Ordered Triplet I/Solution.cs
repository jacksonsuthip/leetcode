public class Solution
{
    public long MaximumTripletValue(int[] nums)
    {

        long maxNum = 0;
        long maxIndex = -1;
        long output = 0;
        long tempMaxNum = long.MaxValue;
        long leftSideMax = 0;

        for (int k = 2; k < nums.Length; k++)
        {
            maxNum = 0;
            maxIndex = -1;

            for (long i = 2; i < nums.Length; i++)
            {
                if (maxNum <= nums[i] && tempMaxNum > nums[i])
                {
                    maxNum = nums[i];
                    maxIndex = i;
                }
            }

            for (long i = 0; i <= maxIndex - 2; i++)
            {
                for (long j = i + 1; j <= maxIndex - 1; j++)
                {
                    long tempLeftMax = nums[i] - nums[j];

                    if (leftSideMax <= tempLeftMax)
                        leftSideMax = tempLeftMax;
                }
            }

            long tempOutput = leftSideMax * maxNum;

            if (output <= tempOutput)
                output = tempOutput;

            tempMaxNum = maxNum;
        }

        return output;
    }
}