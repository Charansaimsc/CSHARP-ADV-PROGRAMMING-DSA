using System;
using System.Diagnostics;

public interface ISortingAlgorithm
{
    string Name { get; }
    void Sort(int[] data);
}
public class BubbleSort : ISortingAlgorithm
{
    public string Name => "Bubble Sort";

    public void Sort(int[] data)
    {
        int n = data.Length;

        for (int i = 0; i < n - 1; i++)
        {
            bool swapped = false;

            for (int j = 0; j < n - i - 1; j++)
            {
                if (data[j] > data[j + 1])
                {
                    int temp = data[j];
                    data[j] = data[j + 1];
                    data[j + 1] = temp;
                    swapped = true;
                }
            }

            if (!swapped)
                break;
        }
    }
}
public class MergeSort : ISortingAlgorithm
{
    public string Name => "Merge Sort";

    public void Sort(int[] data)
    {
        if (data.Length <= 1) return;
        MergeSortInternal(data, 0, data.Length - 1);
    }

    private void MergeSortInternal(int[] data, int left, int right)
    {
        if (left >= right) return;

        int mid = (left + right) / 2;
        MergeSortInternal(data, left, mid);
        MergeSortInternal(data, mid + 1, right);
        Merge(data, left, mid, right);
    }

    private void Merge(int[] data, int left, int mid, int right)
    {
        int[] temp = new int[right - left + 1];
        int i = left, j = mid + 1, k = 0;

        while (i <= mid && j <= right)
            temp[k++] = data[i] <= data[j] ? data[i++] : data[j++];

        while (i <= mid) temp[k++] = data[i++];
        while (j <= right) temp[k++] = data[j++];

        for (int m = 0; m < temp.Length; m++)
            data[left + m] = temp[m];
    }
}
public class QuickSort : ISortingAlgorithm
{
    public string Name => "Quick Sort";

    public void Sort(int[] data)
    {
        QuickSortInternal(data, 0, data.Length - 1);
    }

    private void QuickSortInternal(int[] data, int low, int high)
    {
        if (low >= high) return;

        int pivotIndex = Partition(data, low, high);
        QuickSortInternal(data, low, pivotIndex - 1);
        QuickSortInternal(data, pivotIndex + 1, high);
    }

    private int Partition(int[] data, int low, int high)
    {
        int pivot = data[high];
        int i = low - 1;

        for (int j = low; j < high; j++)
        {
            if (data[j] < pivot)
            {
                i++;
                (data[i], data[j]) = (data[j], data[i]);
            }
        }

        (data[i + 1], data[high]) = (data[high], data[i + 1]);
        return i + 1;
    }
}


public class SortBenchmark
{
    public void Execute(ISortingAlgorithm algorithm, int[] data)
    {
        int[] copy = (int[])data.Clone();

        Stopwatch stopwatch = Stopwatch.StartNew();
        algorithm.Sort(copy);
        stopwatch.Stop();

        Console.WriteLine($"{algorithm.Name} → {stopwatch.ElapsedMilliseconds} ms");
    }
}

