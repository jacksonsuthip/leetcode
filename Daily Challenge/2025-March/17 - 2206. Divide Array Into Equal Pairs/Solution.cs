public class Solution
{
    public bool DivideArray(int[] nums)
    {

        List<int> pairList = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {
            int pairListIndex = pairList.IndexOf(nums[i]);

            if (pairListIndex == -1)
                pairList.Add(nums[i]);
            else
                pairList.RemoveAt(pairListIndex);
        }

        if (pairList.Count == 0)
            return true;
        else
            return false;
    }
}