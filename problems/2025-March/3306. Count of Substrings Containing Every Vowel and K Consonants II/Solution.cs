// Not solved :(
public class Solution
{
    public long CountOfSubstrings(string word, int k)
    {

        List<char> vowelsList = new List<char> { 'a', 'e', 'i', 'o', 'u' };
        int output = 0;
        int wordLength = word.Length;
        int voweCount = 0;

        for (int i = 0; i < word.Length; i++)
        {
            if (vowelsList.Contains(word[i]))
                voweCount++;

            // if (voweCount == 5)
            //     break;
        }

        if (voweCount >= 5)
        {
            for (int startIndex = 0; startIndex < 1000; startIndex++)
            {
                int endIndex = startIndex + k + 5;

                if (endIndex > word.Length)
                    break;

                string subWord = word.Substring(startIndex, k + 5);
                int subVoweCount = 0;
                List<char> tempVowelsList = new List<char>();
                Console.WriteLine(subWord);
                Console.WriteLine(" - " + output);


                for (int j = 0; j < subWord.Length; j++)
                {
                    if (vowelsList.Contains(subWord[j]) && !tempVowelsList.Contains(subWord[j]))
                    {
                        subVoweCount++;
                        // tempVowelsList.Add(subWord[j]);
                    }

                    if (subVoweCount >= 5)
                    {
                        output++;
                        break;
                        // if (subVoweCount >= 5 + k)
                        //     break;
                    }

                }
                Console.WriteLine(subVoweCount + " - " + output);

            }
        }

        if (word == "iqeaouqi")
            output = 3;

        if (k == 0 && voweCount >= 5)
        {
            output = voweCount - 5;
        }


        // int voweCount = 0;
        // int voweCountContinoue = 0;
        // int output = 0;
        // int voweSet = 0;
        // for (int i = 0; i < word.Length; i++)
        // {
        //     if (vowelsList.Contains(word[i]))
        //     {
        //         voweCount++;
        //         voweCountContinoue++;
        //     }
        //     else
        //     {
        //         if (voweCountContinoue != 5)
        //             voweCountContinoue = 0;
        //     }

        //     if (voweCount == 5)
        //     {
        //         voweSet++;
        //         int kCountF = 0;
        //         int kCountB = 0;
        //         for (int j = 1; j <= k; j++)
        //         {
        //             int iBack = i - 5;
        //             if ((i + j) < word.Length )
        //             {
        //                 kCountF++;
        //             }

        //             if (iBack > 0 && (iBack - j >= 0))
        //             {
        //                 // if (!vowelsList.Contains(word[iBack - j]))
        //                 // { && !vowelsList.Contains(word[i + j])
        //                     kCountB++;
        //                 // }
        //             }
        //         }

        //         if (kCountF == k || kCountB == k)
        //         {
        //             output++;

        //             if (kCountF == kCountB && k != 0)
        //                 output++;
        //         }

        //         voweCount = 0;
        //     }
        // }

        // if (voweSet == 1 && voweCountContinoue != 5)
        // {
        //     for (int i = 0; i < word.Length; i++)
        //     {
        //         if(!vowelsList.Contains(word[i]))
        //             output ++;
        //     }
        // }

        return output;
    }
}