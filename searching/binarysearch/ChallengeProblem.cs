/*You are given a list of integers. Write a program that uses Linear Search to find the first
missing positive integer in the list and Binary Search to find the index of a given target
number.
Approach:
1. Linear Search for the first missing positive integer:
o Iterate through the list and mark each number in the list as visited (you can
use negative marking or a separate array).
o Traverse the array again to find the first positive integer that is not marked.
2. Binary Search for the target index:
o After sorting the array, perform binary search to find the index of the given
target number.
o Return the index if found, otherwise return -1.*/

using System;

public class SearchOperations
{
    private int[] numbers;

    public SearchOperations(int[] numbers)
    {
        this.numbers = numbers;
    }
    public int FindFirstMissingPositive()
    {
        int n = numbers.Length;
        bool[] visited = new bool[n + 1];

        for (int i = 0; i < n; i++)
        {
            if (numbers[i] > 0 && numbers[i] <= n)
            {
                visited[numbers[i]] = true;
            }
        }

        for (int i = 1; i <= n; i++)
        {
            if (!visited[i])
            {
                return i;
            }
        }

        return n + 1;
    }

    
    public int FindTargetIndex(int target)
    {
        Array.Sort(numbers); 

        int low = 0;
        int high = numbers.Length - 1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (numbers[mid] == target)
            {
                return mid;
            }
            else if (numbers[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return -1;
    }
}
