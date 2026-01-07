using System;
namespace BinarySearch
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] array = { 4, 5, 6, 7, 1, 2, 3 };
            //RotatedSortedArray RS = new RotatedSortedArray(array);
            //Console.WriteLine(RS.FindSmallest());


            //int[] array = { 1, 3, 20, 4, 1, 0 };

            //PeakElementFinder finder = new PeakElementFinder(array);
            //int peakIndex = finder.FindPeakIndex();

            //Console.WriteLine("Peak index: " + peakIndex);
            //Console.WriteLine("Peak element: " + array[peakIndex]);



            //    int[,] matrix =
            //    {
            //    { 1, 3, 5, 7 },
            //    { 10, 11, 16, 20 },
            //    { 23, 30, 34, 60 }
            //};

            //    MatrixBinarySearch search = new MatrixBinarySearch(matrix);
            //    var result = search.SearchTarget(16);

            //    if (result.row != -1)
            //    {
            //        Console.WriteLine($"Target found at ({result.row}, {result.col})");
            //    }
            //    else
            //    {
            //        Console.WriteLine("Target not found");
            //    }




            //int[] array = { 1, 2, 2, 2, 3, 4, 5 };
            //int target = 2;

            //FirstLastOccurrence search = new FirstLastOccurrence(array);

            //int first = search.FindFirstOccurrence(target);
            //int last = search.FindLastOccurrence(target);

            //Console.WriteLine("First Occurrence: " + first);
            //Console.WriteLine("Last Occurrence: " + last);


            int[] list = { 3, 4, -1, 1 };
            int target = 4;

            SearchOperations search = new SearchOperations(list);

            int missing = search.FindFirstMissingPositive();
            Console.WriteLine("First Missing Positive: " + missing);

            int index = search.FindTargetIndex(target);
            Console.WriteLine("Index of target: " + index);
        }
    }
}