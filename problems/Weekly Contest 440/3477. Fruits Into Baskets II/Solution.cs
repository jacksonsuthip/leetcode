public class Solution
{
    public int NumOfUnplacedFruits(int[] fruits, int[] baskets)
    {

        int output = 0;
        List<int> alreadyLookdeIndex = new List<int>();

        for (int i = 0; i < fruits.Length; i++)
        {
            bool added = true;

            for (int j = 0; j < baskets.Length; j++)
            {
                //Console.WriteLine("" + alreadyLookdeIndex.ToString());
                if (fruits[i] <= baskets[j] && !alreadyLookdeIndex.Contains(j))
                {
                    Console.WriteLine(fruits[i] + " - " + baskets[j]);
                    alreadyLookdeIndex.Add(j);
                    output++;
                    break;
                }

                // if (added)
                //     output++;
                // else
                //     break;
            }

        }

        return fruits.Length - output;
    }
}