public class Solution
{
    public int MinOperations(int[] nums)
    {

        int output = 0;

        // List<int> numsList = nums.ToList();
        int[] numsList = new int[nums.Length];
        Array.Copy(nums, numsList, nums.Length);

        for (int i = 0; i < 1000000; i++)
        {
            if (i + 2 == numsList.Length)
                break;

            if (numsList[i] == 1)
            {
                continue;
            }
            else
            {
                numsList[i] = 1;
                numsList[i + 1] = numsList[i + 1] == 0 ? 1 : 0;
                numsList[i + 2] = numsList[i + 2] == 0 ? 1 : 0;
                output++;
            }
        }

        if (numsList.Contains(0))
            output = -1;

        return output;
    }
}