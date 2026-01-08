using System;
using System.Text;
using System.Diagnostics;

public class StringConcatenation
{
    public void Concatenate(int iterations)
    {
        string result = string.Empty;

        for (int i = 0; i < iterations; i++)
        {
            result += "a";
        }
    }
}


public class StringBuilderConcatenation
{
    public void Concatenate(int iterations)
    {
        StringBuilder builder = new StringBuilder(iterations);

        for (int i = 0; i < iterations; i++)
        {
            builder.Append("a");
        }
    }
}


public class ConcatenationBenchmark
{
    public void MeasureString(int iterations)
    {
        StringConcatenation sc = new StringConcatenation();

        Stopwatch sw = Stopwatch.StartNew();
        sc.Concatenate(iterations);
        sw.Stop();

        Console.WriteLine($"String → {sw.ElapsedMilliseconds} ms");
    }

    public void MeasureStringBuilder(int iterations)
    {
        StringBuilderConcatenation sbc = new StringBuilderConcatenation();

        Stopwatch sw = Stopwatch.StartNew();
        sbc.Concatenate(iterations);
        sw.Stop();

        Console.WriteLine($"StringBuilder → {sw.ElapsedMilliseconds} ms");
    }
}
