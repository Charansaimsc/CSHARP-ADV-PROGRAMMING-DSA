using System;
using System.Diagnostics;

public class Comparison
{
	private readonly int[] arr;
	
	public Comparison(int[] arr)
	{
		this.arr = arr;
	}
	public int LinearSearchs(int target)
	{
		for(int i = 0; i < arr.Length; i++)
		{
			if(arr[i] == target)
			{
				return i;
			}
		}
		return -1;
	}
	public int BinarySearchs(int target)
	{
		int low = 0;
		int high = arr.Length - 1;
		while (low < high)
		{
			int mid =low+(high-low)/2;
			if (arr[mid] == target)
			{
				return mid;
			}
			else if (arr[mid] < target)
			{
                low = mid + 1;
            }
				
			else
				high = mid - 1;
        }
		return -1;
	}
}
