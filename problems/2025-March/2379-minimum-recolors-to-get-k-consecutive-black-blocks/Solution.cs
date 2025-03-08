public class Solution
{
    public int MinimumRecolors(string blocks, int k)
    {

        int output = 99999;
        int tempOutput = 0;
        int blackCount = 0;
        int maxBlackCount = 0;
        int maxBlackIntexEnd = 0;
        bool loopResult = false;


        for (int i = 0; i < blocks.Length; i++)
        {
            if (blocks[i] == 'B')
            {
                blackCount++;

                if (maxBlackCount < blackCount)
                {
                    maxBlackCount = blackCount;
                    maxBlackIntexEnd = i;
                }

                if (blackCount == k)
                {
                    output = 0;
                    loopResult = true;
                    break;
                }
            }
            else
            {
                blackCount = 0;
            }
        }

        if (!loopResult)
        {
            string subBlocks = blocks;
            Console.WriteLine("--" + (blocks.Length - k));

            for (int j = 0; j <= (blocks.Length - k); j++)
            {
                tempOutput = 0;

                for (int i = 0; i < k; i++)
                {
                    if (subBlocks[i] == 'W')
                    {
                        tempOutput++;
                    }
                }

                if (tempOutput <= output)
                {
                    output = tempOutput;
                }

                subBlocks = subBlocks.Substring(1);
            }

            if (!blocks.Contains('B'))
                output = k;
        }

        return output;
    }
}