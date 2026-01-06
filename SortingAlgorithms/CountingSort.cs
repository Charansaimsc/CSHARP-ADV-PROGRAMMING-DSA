using System;

public class CountingSorter
{
    private int[] ages;
    private const int MIN_AGE = 10;
    private const int MAX_AGE = 18;

    public CountingSorter(int[] ages)
    {
        this.ages = ages;
    }

    public void Sort()
    {
        int range = MAX_AGE - MIN_AGE + 1;

        int[] count = new int[range];
        int[] output = new int[ages.Length];

        for (int i = 0; i < ages.Length; i++)
        {
            count[ages[i] - MIN_AGE]++;
        }

        for (int i = 1; i < count.Length; i++)
        {
            count[i] += count[i - 1];
        }

        for (int i = ages.Length - 1; i >= 0; i--)
        {
            int age = ages[i];
            int index = count[age - MIN_AGE] - 1;

            output[index] = age;
            count[age - MIN_AGE]--;
        }

        for (int i = 0; i < ages.Length; i++)
        {
            ages[i] = output[i];
        }
    }

    public void Display()
    {
        foreach (int age in ages)
        {
            Console.Write(age + " ");
        }
        Console.WriteLine();
    }
}
