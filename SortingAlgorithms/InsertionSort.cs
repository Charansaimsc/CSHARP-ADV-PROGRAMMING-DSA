using System;

public class InsertionSort
{
	private int[] EmployeeId;

	public InsertionSort(int[] EmployeeId)
	{
		this.EmployeeId = EmployeeId;
	}
	public void Sort()
	{
		for (int i = 1; i < EmployeeId.Length; i++)
		{
			int key = EmployeeId[i];
			int j = i - 1;
			while (j >= 0 && EmployeeId[j] > key)
			{
				EmployeeId[j + 1] = EmployeeId[j];
				j--;
			}
            EmployeeId[j + 1] = key;

		}
	}
	public void Display()
	{
		for(int i = 1; i < EmployeeId.Length; i++)
		{
			Console.WriteLine(EmployeeId[i]);
		}
	}
}