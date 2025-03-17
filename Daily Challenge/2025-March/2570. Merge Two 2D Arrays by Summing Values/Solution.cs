public class Solution
{
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {

        // int[][] toSort = new int[(nums1.Length - 1)][];
        List<List<int>> resultList = new List<List<int>>();
        List<int> uniqueId = new List<int>();

        for (int i = 0; i < nums1.Length; i++)
        {
            for (int j = 0; j < nums2.Length; j++)
            {
                List<int> innerList = new List<int>();

                if (nums1[i][0] == nums2[j][0])
                {
                    innerList.Add(nums1[i][0]);
                    innerList.Add(nums1[i][1] + nums2[j][1]);
                    uniqueId.Add(nums1[i][0]);
                    resultList.Add(innerList);
                    break;
                }
                else
                {
                    if (j == (nums2.Length - 1))
                    {
                        uniqueId.Add(nums1[i][0]);
                        innerList.Add(nums1[i][0]);
                        innerList.Add(nums1[i][1]);
                        resultList.Add(innerList);
                    }
                }
            }
        }

        for (int j = 0; j < nums2.Length; j++)
        {
            List<int> innerList = new List<int>();
            if (!uniqueId.Contains(nums2[j][0]))
            {
                uniqueId.Add(nums2[j][0]);
                innerList.Add(nums2[j][0]);
                innerList.Add(nums2[j][1]);
                resultList.Add(innerList);
            }
        }

        int[][] jaggedArray = ConvertToJaggedArray(resultList);

        return jaggedArray;

    }

    static int[][] ConvertToJaggedArray(List<List<int>> list)
    {
        // Convert each inner List<int> to int[] and then the whole List<List<int>> to int[][]
        int[][] jaggedArray = new int[list.Count][];

        for (int i = 0; i < list.Count; i++)
        {
            jaggedArray[i] = list[i].ToArray(); // Convert each List<int> to int[]
        }

        Array.Sort(jaggedArray, (a, b) => a[0].CompareTo(b[0]));

        return jaggedArray;
    }
}