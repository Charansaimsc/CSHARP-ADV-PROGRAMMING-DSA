using System;

public class QuickSorter
{
    private int[] prices;
    public QuickSorter(int[] prices)
    {
        this.prices = prices;
    }

    public void Sort()
    {
        QuickSort(0, prices.Length - 1);
    }

    private void QuickSort(int low, int high)
    {
        if (low < high)
        {
            int pivotIndex = Partition(low, high);

            QuickSort(low, pivotIndex - 1);
            QuickSort(pivotIndex + 1, high);
        }
    }

    private int Partition(int low, int high)
    {
        int pivot = prices[high]; 
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (prices[j] < pivot)
            {
                i++;

                int temp = prices[i];
                prices[i] = prices[j];
                prices[j] = temp;
            }
        }

        int tempPivot = prices[i + 1];
        prices[i + 1] = prices[high];
        prices[high] = tempPivot;

        return i + 1; 
    }

    public void Display()
    {
        foreach (int price in prices)
        {
            Console.Write(price + " ");
        }
        Console.WriteLine();
    }
}
