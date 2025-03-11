using System;
using System.Collections.Generic;

public delegate void DisplayMessage(string message);
public class PublishMessage
{
    public DisplayMessage firstMessage;
    public void ShowMessage()
    {
        if (firstMessage != null)
        {
            firstMessage("Delegate Event Triggered!!");
        }
        firstMessage?.Invoke("Delegate Event Triggered!!");
    }
}

public class SubscribeMessage
{
    public void MessageDisplay(string message)
    {
        Console.WriteLine($"Recevied message: {message}");
    }
}

class Program
{
    static void Main()
    {
        //string input = "abcabbcbb";
        //int length = LengthOfLongestSubstring(input);
        //Console.WriteLine("The length of the longest substring without repeating characters is: " + length);
        //int resultLength = LengthOfLongestNonRepeatingSubstring(input);
        //Console.WriteLine($"Length {resultLength}");
        //int MaxInteger = Max(10, 20);
        //Console.WriteLine($"{MaxInteger}");
        //string MaxString = Max("banana", "apple");
        //Console.WriteLine($"{MaxString}");
        //FirstGenericClass<int> firstGenericClassObj1 = new FirstGenericClass<int>(833);
        //int integerValue = firstGenericClassObj1.GetValue();
        //Console.WriteLine($"{integerValue}");
        //FirstGenericClass<string> firstGenericClassObj2 = new FirstGenericClass<string>("Mallikarjuna");
        //string stringValue = firstGenericClassObj2.GetValue();
        //Console.WriteLine($"{stringValue}");
        //PublishMessage publisher = new PublishMessage();
        //SubscribeMessage subscriber = new SubscribeMessage();
        //publisher.firstMessage += subscriber.MessageDisplay;
        //publisher.ShowMessage();
        //int[] arr1 = [1, 2, 3, 0, 0 ,0];
        //int[] arr2 = [2, 4, 7];
        //MergeSortedArray(arr1, 3, arr2, 3);
        //int[] arr1 = [3, 2, 2, 3];
        //Console.WriteLine(RemoveElement(arr1, 3));
        int[] arr1 = [1, 1, 2];
        int[] arr2 = [0, 0, 1, 1, 1, 2, 2, 3, 3, 4];
        Console.WriteLine(RemoveDuplicates(arr2));
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

    static T Max<T>(T firstValue, T secondValue)  where T : IComparable<T>
    {
        if(firstValue.CompareTo(secondValue) < 0)
            return secondValue;
        return firstValue;
    }

    static void MergeSortedArray(int[] firstArray, int firstArrayLength, int[] secondArray, int secondArrayLength)
    {
        int arrayOneLength = firstArrayLength - 1;
        int arrayTwoLength = secondArrayLength - 1;
        int totalArraysLength = firstArrayLength + secondArrayLength - 1;
        while(arrayOneLength >= 0 &&  arrayTwoLength >= 0)
        {
            if (firstArray[arrayOneLength] >  secondArray[arrayTwoLength])
            {
                firstArray[totalArraysLength--] = firstArray[arrayOneLength--];
            }
            else
            {
                firstArray[totalArraysLength--] = secondArray[arrayTwoLength--];
            }
        }
        while(arrayTwoLength >= 0)
        {
            firstArray[totalArraysLength--]= secondArray[arrayTwoLength--];
        }
        foreach(var item in firstArray)
        {
            Console.Write(item);
        }
    }

    static int RemoveElement(int[] integerArray, int element)
    {
        int arrayLength = integerArray.Length;
        int i = 0;
        int j = 0;
        int count = 0;
        while(i < arrayLength)
        {
            if (integerArray[i] != element)
            {
                integerArray[j++] = integerArray[i];
                count++;
            }
            i++;
        }
        return count;
    }

    static int RemoveDuplicates(int[] nums)
    {
        if(nums.Length == 0)
            return 0;
        int index = 0;
        for (int i = 1; i < nums.Length; i++)
        {
            if(nums[i] != nums[index])
            {
                index++;
                nums[index] = nums[i];
                nums[nums.Length - 1] = 0;
            }
        }
        return index + 1;
    }

}

public class FirstGenericClass<T>
{
    private T firstValue;
    public FirstGenericClass(T _value)
    {
         firstValue = _value;
    }
    public T GetValue()
    {
        return firstValue;
    }
}