using System;

public class HeapSorter
{
    private int[] salaries;
    public HeapSorter(int[] salaries)
    {
        this.salaries = salaries;
    }

    public void Sort()
    {
        int n = salaries.Length;
        
        for (int i = n / 2 - 1; i >= 0; i--)
        {
            Heapify(n, i);
        }

        for (int i = n - 1; i > 0; i--)
        {
            int temp = salaries[0];
            salaries[0] = salaries[i];
            salaries[i] = temp;

            Heapify(i, 0);
        }
    }

    private void Heapify(int heapSize, int i)
    {
        int largest = i;
        int left = 2 * i + 1;
        int right = 2 * i + 2;

        if (left < heapSize && salaries[left] > salaries[largest])
            largest = left;

        if (right < heapSize && salaries[right] > salaries[largest])
            largest = right;

        if (largest != i)
        {
            int swap = salaries[i];
            salaries[i] = salaries[largest];
            salaries[largest] = swap;

            Heapify(heapSize, largest);
        }
    }

    public void Display()
    {
        foreach (int salary in salaries)
        {
            Console.Write(salary + " ");
        }
        Console.WriteLine();
    }
}
