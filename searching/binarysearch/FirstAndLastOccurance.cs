using System;

public class FirstLastOccurrence
{
    private readonly int[] array;

    public FirstLastOccurrence(int[] array)
    {
        this.array = array;
    }

    public int FindFirstOccurrence(int target)
    {
        int low = 0;
        int high = array.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] == target)
            {
                result = mid;      // potential answer
                high = mid - 1;    // move left
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }

    public int FindLastOccurrence(int target)
    {
        int low = 0;
        int high = array.Length - 1;
        int result = -1;

        while (low <= high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] == target)
            {
                result = mid;     
                low = mid + 1;    
            }
            else if (array[mid] < target)
            {
                low = mid + 1;
            }
            else
            {
                high = mid - 1;
            }
        }

        return result;
    }
}
