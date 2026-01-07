using System;

public class PeakElementFinder
{
    private readonly int[] array;

    public PeakElementFinder(int[] array)
    {
        this.array = array;
    }

    public int FindPeakIndex()
    {
        int low = 0;
        int high = array.Length - 1;

        while (low < high)
        {
            int mid = low + (high - low) / 2;

            if (array[mid] < array[mid + 1])
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
