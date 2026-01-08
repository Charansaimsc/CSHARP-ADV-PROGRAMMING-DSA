using System;
using System.Diagnostics;
namespace AlgorithmicAnalysis
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int size = 1000000;
            //int target = 999999;

            //int[] data = new int[size];
            //for (int i = 0; i < size; i++)
            //{
            //    data[i] = i;
            //}
            //Comparison comparison = new Comparison(data);
            //Stopwatch stopwatch = new Stopwatch();
            //stopwatch.Start();
            //comparison.LinearSearchs(target);
            //stopwatch.Stop();
            //Console.WriteLine("Linear Search Time: " + stopwatch.ElapsedMilliseconds + " ms");


            //stopwatch.Restart();
            //comparison.BinarySearchs( target);
            //stopwatch.Stop();
            //Console.WriteLine("BinarySearch : " + stopwatch.ElapsedMilliseconds);



            //    int size = 100000;
            //    int[] data = GenerateData(size);

            //    ISortingAlgorithm[] algorithms =
            //    {
            //    new BubbleSort(),
            //    new MergeSort(),
            //    new QuickSort()
            //};

            //    SortBenchmark benchmark = new SortBenchmark();

            //    foreach (var algo in algorithms)
            //    {
            //        benchmark.Execute(algo, data);
            //    }

            //    Console.ReadLine();
            //}

            //private static int[] GenerateData(int size)
            //{
            //    Random random = new Random();
            //    int[] data = new int[size];

            //    for (int i = 0; i < size; i++)
            //        data[i] = random.Next();

            //    return data;



            //ConcatenationBenchmark CB = new ConcatenationBenchmark();
            //CB.MeasureString(100000);
            //CB.MeasureStringBuilder(100000);

            string filePath = "Sample.txt";

            FileReadBenchmark benchmark = new FileReadBenchmark();

            benchmark.MeasureStreamReader(filePath);
            benchmark.MeasureFileStream(filePath);
        }
    }
}