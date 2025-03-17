public class Solution
{
    public int[] ApplyOperations(int[] nums)
    {

        List<int> numList = nums.ToList();
        List<int> numListSort = new List<int>();
        List<int> numListZero = new List<int>();

        for (int i = 0; i < 10000; i++)
        {
            if (i == (nums.Length - 1))
            {
                break;
            }

            if (numList[i] == numList[i + 1])
            {
                numList[i] = numList[i] * 2;
                numList[i + 1] = 0;
            }
        }

        foreach (int num in numList)
        {
            if (num != 0)
            {
                numListSort.Add(num);
            }
            else
            {
                numListZero.Add(0);
            }
        }

        numListSort.AddRange(numListZero);

        int[] result = numListSort.ToArray();

        return result;
    }
}