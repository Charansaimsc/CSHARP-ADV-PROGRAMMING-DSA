/*Search for a Target Value in a 2D Sorted Matrix
Problem: You are given a 2D matrix where each row is sorted in ascending order. Write a
program that performs Binary Search to find a target value in the matrix*/
using System;

public class MatrixBinarySearch
{
    private readonly int[,] matrix;
    private readonly int rows;
    private readonly int cols;

    public MatrixBinarySearch(int[,] matrix)
    {
        this.matrix = matrix;
        rows = matrix.GetLength(0);
        cols = matrix.GetLength(1);
    }

    public (int row, int col) SearchTarget(int target)
    {
        for (int i = 0; i < rows; i++)
        {
            int left = 0;
            int right = cols - 1;

            while (left <= right)
            {
                int mid = left + (right - left) / 2;

                if (matrix[i, mid] == target)
                {
                    return (i, mid);
                }
                else if (matrix[i, mid] < target)
                {
                    left = mid + 1;
                }
                else
                {
                    right = mid - 1;
                }
            }
        }

        return (-1, -1);
    }
}
