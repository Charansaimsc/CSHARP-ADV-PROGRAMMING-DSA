using System;
namespace Searching
{
    public class Program
    {
        static void Main(string[] args)
        {
            int[] numbers = { 1, 4, 5, -8, 44, 3, 2 };
            FirstNegativeNumber FN = new FirstNegativeNumber(numbers);
            Console.WriteLine(FN.FindNegative());
        }
    }
}