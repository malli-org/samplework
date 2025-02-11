using System;
using System.Collections.Generic;

class Program
{
    static void Main()
    {
        string input = "abcabbcbb";
        int length = LengthOfLongestSubstring(input);
        Console.WriteLine("The length of the longest substring without repeating characters is: " + length);
        int resultLength = LengthOfLongestNonRepeatingSubstring(input);
        Console.WriteLine($"Length {resultLength}");
    }

    static int LengthOfLongestSubstring(string s)
    {
        int n = s.Length;
        int maxLength = 0;
        Dictionary<char, int> charIndexMap = new Dictionary<char, int>();
        int start = 0;

        for (int end = 0; end < n; end++)
        {
            if (charIndexMap.ContainsKey(s[end]))
            {
                start = Math.Max(charIndexMap[s[end]] + 1, start);
            }
            charIndexMap[s[end]] = end;
            maxLength = Math.Max(maxLength, end - start + 1);
        }

        return maxLength;
    }

    static int LengthOfLongestNonRepeatingSubstring(string input)
    {
        int left = 0;
        int right = 0;
        int stringLength = input.Length;
        int subStringLength = 0;
        HashSet<char> chars = [];
        while (right < stringLength)
        {
            if (!chars.Contains(input[right]))
            {
                chars.Add(input[right]);
                right++;
                subStringLength = Math.Max(subStringLength, right - left);
            }
            else
            {
                chars.Remove(input[right]);
                left++;
            }
        }
        return subStringLength;
    }
}