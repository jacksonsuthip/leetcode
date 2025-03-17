public class Solution
{
    public bool CheckPowersOfThree(int n)
    {

        List<int> powersOfThree = new List<int> { 1, 3, 9, 27, 81, 243, 729, 2187, 6561, 19683, 59049, 177147, 531441, 1594323, 4782969, 14348907 };
        bool result = false;
        double pov3 = 0;
        int subValue = n;
        int powersOfThreeValue = 0;
        int powersOfThreeValueTemp = 0;

        for (int i = 0; i <= 7; i++)
        {
            subValue = FindTheNerest(subValue, powersOfThree, ref powersOfThreeValue);

            if (powersOfThreeValueTemp == powersOfThreeValue) break;

            pov3 += powersOfThreeValue;
            powersOfThreeValueTemp = powersOfThreeValue;

            Console.WriteLine(i + " - " + subValue + " - " + powersOfThreeValue + " - " + pov3);

            if (pov3 == n)
            {
                result = true;
                break;
            }

            if (pov3 >= n) break;
            if (subValue == 0) break;
        }

        return result;
    }

    public int FindTheNerest(int n, List<int> powersOfThree, ref int powersOfThreeValue)
    {
        int result = 0;

        for (int k = 0; k < powersOfThree.Count; k++)
        {
            if (powersOfThree[k] > n)
            {
                result = n - powersOfThree[k - 1];
                powersOfThreeValue = powersOfThree[k - 1];
                break;
            }
        }

        return result;
    }

}



// for (int k = 1; k <= 5; k++)
// {
//     int loopStart = 1;
//     int loopIncrement = 1;

//     pov3 = 0;

//     if (k == 2)
//     {
//         loopStart = 0;
//         loopIncrement = k;
//     } 
//     else if (k == 3) 
//     {
//         loopStart = 3;
//         loopIncrement = k;
//     } 
//     else if(k == 4)
//     {
//         loopStart = 0;
//         loopIncrement = 3;
//     }
//     else if(k == 5)
//     {
//         loopStart = 2;
//         loopIncrement = 1;
//     }


//     for (int i = loopStart; i <= 15; i += loopIncrement)
//     {
//         pov3 += Math.Pow(3, i);

//         if (pov3 == n)
//         {
//             result = true;
//             break;
//         }
//         Console.WriteLine(i + " - " + pov3);
//     }

//     if(result)
//         break;
// }