public class Solution
{
    public int[] PivotArray(int[] nums, int pivot)
    {

        List<int> Left = new List<int>();
        List<int> Right = new List<int>();
        List<int> Middle = new List<int>();
        List<int> mergedList = new List<int>();
        // List<int> indexZero = new List<int>();
        // List<int> index = new List<int>();

        for (int i = 0; i < nums.Length; i++)
        {

            if (nums[i] < pivot)
            {
                // if(nums[i] == 0)
                //     indexZero.Add(Left.Count);

                Left.Add(nums[i]);
            }
            else if (nums[i] > pivot)
            {
                Right.Add(nums[i]);
            }
            else
            {
                Middle.Add(nums[i]);
            }
        }

        // Left = Left.Where(x => x != 0).OrderByDescending(x => x).ToList();

        // foreach (int zero in indexZero)
        // {
        //     Left.Insert(zero, 0);
        // }

        mergedList.AddRange(Left);
        mergedList.AddRange(Middle);
        mergedList.AddRange(Right);

        return mergedList.ToArray();
    }
}