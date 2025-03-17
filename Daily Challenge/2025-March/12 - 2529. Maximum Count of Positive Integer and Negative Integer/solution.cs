public class Solution
{
    public int MaximumCount(int[] nums)
    {

        int output = 0;
        int positiveOutput = 0;

        for (int i = 0; i < nums.Length; i++)
        {
            if (nums[i] > 0)
                positiveOutput++;

            if (nums[i] < 0)
                output++;
        }

        if (output < positiveOutput)
            output = positiveOutput;

        return output;
    }
}