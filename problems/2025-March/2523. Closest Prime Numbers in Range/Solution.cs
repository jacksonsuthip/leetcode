
// AI - GPT

public class Solution
{
    public int[] ClosestPrimes(int left, int right)
    {

        List<int> primeList = new List<int>();
        Dictionary<int, int> myDict = new Dictionary<int, int>();

        int[] output = new int[2];
        int count = 0;
        int lowDist = 9999;

        for (int i = left; i <= right; i++)
        {
            count++;

            if (IsPrime(i))
            {
                if (primeList.Count != 0)
                {
                    myDict[i] = count;
                }

                count = 0;
                primeList.Add(i);
            }
        }

        // If there are fewer than 2 primes, return [-1, -1]
        if (primeList.Count < 2)
        {
            return new int[] { -1, -1 };
        }

        // Find the pair of primes with the smallest difference
        int minDiff = int.MaxValue;

        for (int i = 1; i < primeList.Count; i++)
        {
            int diff = primeList[i] - primeList[i - 1];
            if (diff < minDiff)
            {
                minDiff = diff;
                output[0] = primeList[i - 1];
                output[1] = primeList[i];
            }
        }

        return output;

    }

    // AI 
    public static bool IsPrime(int N)
    {
        // If N is less than or equal to 1, it's not prime
        if (N <= 1)
            return false;

        // 2 is the only even prime number
        if (N == 2)
            return true;

        // If N is even and greater than 2, it's not prime
        if (N % 2 == 0)
            return false;

        // Check divisibility from 3 up to the square root of N
        for (int i = 3; i * i <= N; i += 2)  // Only check odd numbers
        {
            if (N % i == 0)
                return false;  // Found a divisor, so N is not prime
        }

        // No divisors found, so N is prime
        return true;
    }
}