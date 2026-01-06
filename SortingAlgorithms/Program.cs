

using System;
namespace Sorting
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] marks = { 12, 3, 99, 77, 55, 33, 100 };
            BubbleSort BSort = new BubbleSort(marks);
            BSort.SortMarks();
            BSort.Display();


            int[] EmployeeId = { 101, 990, 888, 222, 001 };
            InsertionSort IS = new InsertionSort(EmployeeId);
            IS.Sort();
            IS.Display();


            int[] BookPrices = { 1009, 999, 888, 444, 1003, 33 };
            MergeSorter MS = new MergeSorter(BookPrices);
            MS.Sort();
            MS.Display();

            int[] ProductPrices = {11,66,4,4,366,776,2,44};
            QuickSorter QS = new QuickSorter(ProductPrices);
            QS.Sort();
            QS.Display();


            int[] ExamScores = { 99, 99, 98, 77, 66, 88, 99, 11 };
            SelectionSort SS = new SelectionSort(ExamScores);
            SS.Sort();
            SS.Display();

            int[] ExpectedSalary = { 13333, 233232, 454545, 435455, 9034 };
            HeapSorter HS = new HeapSorter(ExpectedSalary);
            HS.Sort();
            HS.Display();


            int[] studentAges = { 15, 12, 18, 10, 14, 12, 16, 15 };
            CountingSorter CS = new CountingSorter(studentAges);
            CS.Sort();
            CS.Display();
        }
    }
}