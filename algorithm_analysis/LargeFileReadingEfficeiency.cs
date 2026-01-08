using System;
using System.Text;
using System.IO;
using System.Diagnostics;

public class TextFileReader
{
    public void Read(string filePath)
    {
        using (StreamReader reader = new StreamReader(filePath))
        {
            while (reader.ReadLine() != null)
            {
                
            }
        }
    }
}
public class BinaryFileReader
{
    public void Read(string filePath)
    {
        byte[] buffer = new byte[8192];

        using (FileStream stream = new FileStream(
            filePath,
            FileMode.Open,
            FileAccess.Read))
        {
            while (stream.Read(buffer, 0, buffer.Length) > 0)
            {
                
            }
        }
    }
}

public class FileReadBenchmark
{
    public void MeasureStreamReader(string filePath)
    {
        TextFileReader reader = new TextFileReader();

        Stopwatch sw = Stopwatch.StartNew();
        reader.Read(filePath);
        sw.Stop();

        Console.WriteLine($"StreamReader → {sw.ElapsedMilliseconds} ms");
    }

    public void MeasureFileStream(string filePath)
    {
        BinaryFileReader reader = new BinaryFileReader();

        Stopwatch sw = Stopwatch.StartNew();
        reader.Read(filePath);
        sw.Stop();

        Console.WriteLine($"FileStream → {sw.ElapsedMilliseconds} ms");
    }
}

