using System;
namespace Filehandling
{
    public class Program
    {
        static void Main(string[] args)
        {
            //ReverseString RS = new ReverseString("charan");
            //Console.WriteLine(RS.Reverse());

            //RemoveDuplicatesUsingStringBuilder RD = new RemoveDuplicatesUsingStringBuilder("CHARAN");
            //Console.WriteLine(RD.removeDuplicates());

            //string[] _strings = { "hello", "charan", "sai" };
            //ConcatenateString CS = new ConcatenateString(_strings);
            //    Console.WriteLine(CS.Concatenate());


            //StringPerformanceComparision SPC = new StringPerformanceComparision(10000000));
            //SPC.Display();

            //FileLineReader FR = new FileLineReader("sample.txt");
            //FR.ReadLineByLine();

            //CountOccurance CO = new CountOccurance("sample.txt","line");
            //Console.WriteLine(CO.StringCounter());

            //ByteToChar BC = new ByteToChar("sample.txt");
            //BC.ByteToCharacter();

            UserInputFileWriter writer = new UserInputFileWriter("userInput.txt");
            writer.WriteInputToFile();
        }
    }
}