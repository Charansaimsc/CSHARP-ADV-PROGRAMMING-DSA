using System;

public class BubbleSort
{
	private int[] marks;
	public BubbleSort(int[] marks)
	{
		this.marks = marks;
	}
	public void SortMarks()
	{
		bool swapped;
		for (int i = 0; i < marks.Length-1; i++)
		{
			swapped = false;
			for (int j = 0; j < marks.Length-i-1; j++)
			{
				if (marks[j] > marks[j + 1])
				{
					int temp = marks[j];
					marks[j] = marks[j + 1];
					marks[j + 1] = temp;
					swapped = true;

				}
			}

			if (!swapped)
			{
				break;
			}
		}

	}
	public void Display()
	{
		for(int i = 0; i < marks.Length; i++)
		{
			Console.WriteLine(marks[i]);
		}
	}

}

