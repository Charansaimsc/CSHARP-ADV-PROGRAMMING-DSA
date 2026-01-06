/*Problem Statement:
A bookstore maintains a list of book prices in an array. Implement Merge Sort in C# to sort
the prices in ascending order.
Hint:
● Divide the array into two halves recursively.
● Sort both halves individually.
● Merge the sorted halves by comparing elements.*/
using System;

public class MergeSorter
{
    private int[] prices;

    public MergeSorter(int[] prices)
    {
        this.prices = prices;
    }

    public void Sort()
    {
        MergeSort(0, prices.Length - 1);
    }
       private void MergeSort(int left, int right)
    {
        if (left < right)
        {
            int mid = (left + right) / 2;

            MergeSort(left, mid);
            MergeSort(mid + 1, right);

           Merge(left, mid, right);
        }
    }

    private void Merge(int left, int mid, int right)
    {
        int n1 = mid - left + 1;
        int n2 = right - mid;

        int[] leftArray = new int[n1];
        int[] rightArray = new int[n2];

        for (int i = 0; i < n1; i++)
            leftArray[i] = prices[left + i];

        for (int j = 0; j < n2; j++)
            rightArray[j] = prices[mid + 1 + j];

        int iIndex = 0, jIndex = 0, k = left;

        while (iIndex < n1 && jIndex < n2)
        {
            if (leftArray[iIndex] <= rightArray[jIndex])
            {
                prices[k] = leftArray[iIndex];
                iIndex++;
            }
            else
            {
                prices[k] = rightArray[jIndex];
                jIndex++;
            }
            k++;
        }

        while (iIndex < n1)
        {
            prices[k] = leftArray[iIndex];
            iIndex++;
            k++;
        }

        while (jIndex < n2)
        {
            prices[k] = rightArray[jIndex];
            jIndex++;
            k++;
        }
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
