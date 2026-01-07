using System;
namespace Searching
{
    public class Program
    {
        static void Main(string[] args)
        {
            //int[] numbers = { 1, 4, 5, -8, 44, 3, 2 };
            //FirstNegativeNumber FN = new FirstNegativeNumber(numbers);
            //Console.WriteLine(FN.FindNegative());


            string[] sentences =
    {
            "C# is a powerful language",
            "Linear search is simple",
            "StreamReader reads files",
            "OOPS concepts are important"
        };

            SentenceSearch search = new SentenceSearch(sentences);
            string result = search.FindSentenceContainingWord("search");

            if (result != null)
            {
                Console.WriteLine("Sentence found:");
                Console.WriteLine(result);
            }
            else
            {
                Console.WriteLine("Word not found in any sentence.");
            }
        }
    }
}