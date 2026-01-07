/* Compare StringBuilder Performance
Problem: Write a program that compares the performance of StringBuilder for
concatenating strings multiple times.*/
using System;
using System.Text;
using System.Diagnostics;
public class StringPerformanceComparision
{
    private int turns;
	public StringPerformanceComparision(int turns)
	{
			this.turns = turns;
	}

    public long TestStringConcatenation()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();

        string result = "";
        for (int i = 0; i < turns; i++)
        {
            result += "SaI";
        }

        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
    public long TestStringBuilderComparision()
    {
        Stopwatch stopwatch = Stopwatch.StartNew();
        StringBuilder SB = new StringBuilder();
        for (int i = 0; i < turns; i++)
        {
            SB.Append("sai");
        }
        SB.ToString();
        stopwatch.Stop();
        return stopwatch.ElapsedMilliseconds;
    }
    public void Display()
    {
        Console.WriteLine($"stringTimeTaken: {TestStringConcatenation()}" + $"StingBuilder TimeTaken: {TestStringBuilderComparision()}");
    }
}
