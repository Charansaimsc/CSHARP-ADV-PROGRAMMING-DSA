/* You are given a rotated sorted array. Write a program that performs Binary Search
to find the index of the smallest element in the array.
*/
using System;

public class RotatedSortedArray
{
    private readonly int[] array;

    public RotatedSortedArray(int[] array)
    {
        this.array = array;
    }

    public int FindSmallest()
    {
        int low = 0;
        int high = array.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] > array[high])
            {
                low = mid + 1;
            }
            else
            {
                high = mid;
            }
        }

        return low; 
    }
}
