/* Read User Input and Write to File Using StreamReader
Problem: Write a program that reads user input from the console and writes it to a file.*/

using System;
using System.IO;

public class UserInputFileWriter
{
    private readonly string filePath;

    public UserInputFileWriter(string filePath)
    {
        this.filePath = filePath;
    }

    public void WriteInputToFile()
    {
        try
        {
            Console.WriteLine("Enter text to write into file:");
            string userInput = Console.ReadLine();

            using (StreamWriter writer = new StreamWriter(filePath, true))
            {
                writer.WriteLine(userInput);
            }

            Console.WriteLine("Input successfully written to file.");
        }
        catch (Exception ex)
        {
            Console.WriteLine("Error: " + ex.Message);
        }
    }
}

