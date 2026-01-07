/* You are given an integer array. Write a program that performs Linear Search to find
the first negative number in the array.
*/
using System;

public class FirstNegativeNumber
{
    private int[] numbers;

    public FirstNegativeNumber(int[] numbers)
    {
        this.numbers = numbers;
    }

    public int FindNegative()
    {
        for (int i = 0; i < numbers.Length; i++)
        {
            if (numbers[i] < 0)
            {
                return numbers[i]; 
            }
        }

        return 0; 
    }
}
