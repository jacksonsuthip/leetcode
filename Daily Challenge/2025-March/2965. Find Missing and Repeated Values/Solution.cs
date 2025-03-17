public class Solution
{
    public int[] FindMissingAndRepeatedValues(int[][] grid)
    {

        int[] output = new int[2];
        Hashtable hashtable = new Hashtable();

        for (int i = 0; i < grid.Length; i++)
        {
            for (int j = 0; j < grid[i].Length; j++)
            {
                if (hashtable.ContainsKey(grid[i][j]))
                {
                    output[0] = grid[i][j];
                }
                else
                {
                    hashtable.Add(grid[i][j], i);
                }
            }
        }

        for (int i = 1; i < 5000; i++)
        {
            if (!hashtable.ContainsKey(i))
            {
                output[1] = i;
                break;
            }
        }

        return output;
    }
}