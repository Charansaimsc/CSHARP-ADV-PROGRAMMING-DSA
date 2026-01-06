/*Problem Statement:
A university needs to sort students’ exam scores in ascending order. Implement Selection
Sort in C# to achieve this.
Hint:
● Find the minimum element in the array.
● Swap it with the first unsorted element.
● Repeat the process for the remaining elements*/

using System;

public class SelectionSort

{
	private int[] ExamScores;
	public SelectionSort(int[] ExamScores)
	{
		this.ExamScores = ExamScores;

	}
	public void Sort()
	{
		for (int i = 0; i < ExamScores.Length-1; i++)
		{
			int minIndex = i;
			for (int j = i + 1; j < ExamScores.Length; j++)
			{
				if (ExamScores[j] < ExamScores[minIndex])
				{
					minIndex = j;
				}
			}
			if (minIndex != i)
			{
				int temp = ExamScores[i];
				ExamScores[i] = ExamScores[minIndex];
				ExamScores[minIndex] = temp;
			}
		}
	}
    public void Display()
    {
        foreach (int score in ExamScores)
        {
            Console.Write(score + " ");
        }
        Console.WriteLine();
    }
}
