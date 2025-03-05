public class Solution
{
    public long ColoredCells(int n)
    {

        List<long> numToAdd = new List<long>();
        long tempNum = 1;
        long output = 0;

        numToAdd.Add(tempNum);

        for (int i = 1; i < n; i++)
        {
            tempNum += 2;
            numToAdd.Add(tempNum);
        }

        for (int i = 0; i < numToAdd.Count; i++)
        {
            //Console.WriteLine(numToAdd[i] + "");
            if ((numToAdd.Count - 1) != i)
            {
                output += numToAdd[i] + numToAdd[i];
            }
            else
            {
                output += numToAdd[i];
            }
        }

        return output;
    }
}