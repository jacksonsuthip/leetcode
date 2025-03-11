// AI - GPT by given the SolutionTemp class
public class Solution {
    public int NumberOfSubstrings(string s) {
        int output = 0;
        int left = 0;
        int[] count = new int[3]; // to store counts of 'a', 'b', and 'c'

        for (int right = 0; right < s.Length; right++) {
            // Update the count for the character at the right pointer
            count[s[right] - 'a']++;

            // Check if the window contains all three characters
            while (count[0] > 0 && count[1] > 0 && count[2] > 0) {
                // All three characters 'a', 'b', and 'c' are in the window, so we can add all substrings
                output += s.Length - right;  // All substrings from left to the end of the string

                // Move the left pointer to shrink the window
                count[s[left] - 'a']--;
                left++;
            }
        }

        return output;
    }
}

// Working but **Time Limit Exceeded** Error
public class SolutionTemp {
    public int NumberOfSubstrings(string s) {
        
        int output = 0;
        List<string> addedSubstring = new List<string>();

        for (int startIntex = 0; startIntex <= (s.Length - 3); startIntex++)
        {
            for(int sLength = 3; sLength <= s.Length - startIntex; sLength++)
            {
                string subS = s.Substring(startIntex, sLength);

                if (subS.Contains('a') && subS.Contains('b') && subS.Contains('c'))
                    output++;
            }
        }

        return output;
    }
}