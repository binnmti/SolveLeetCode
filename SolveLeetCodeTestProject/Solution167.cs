﻿
namespace SolveLeetCodeTestProject;

internal class Solution167
{
    internal static int[] TwoSum(int[] numbers, int target)
    {
        var left = 0;
        var right = numbers.Length - 1;
        while(left < right)
        {
            var sum = numbers[left] + numbers[right];
            if (sum == target)
            {
                return [left + 1, right + 1];
            }
            if (sum < target)
            {
                left++;
            }
            else
            {
                right--;
            }
        }
        return [];
    }
}