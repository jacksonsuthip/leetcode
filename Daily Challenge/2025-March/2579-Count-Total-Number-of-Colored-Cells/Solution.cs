public class Solution
{
    public long ColoredCells(int n)
    {

        long tempNum = 1;
        long output = 1;

        for (int i = 1; i < n; i++)
        {
            tempNum += 2;

            if (i == (n - 1))
                output += tempNum + 1;
            else
                output += tempNum + tempNum;
        }

        return output;
    }
}