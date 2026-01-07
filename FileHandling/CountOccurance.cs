/* Count the Occurrence of a Word in a File Using StreamReader
Problem: Write a program that reads a file and counts how many times a specific word
appears in the file.*/

using System;
using System.IO;


public class CountOccurance
{
	private string FilePath;
	private int Count;
	public string word;
	public CountOccurance(string FilePath,string word) 
	{
		this.FilePath = FilePath;
		//this.Count = Count;
		this.word = word;
	}
	public int StringCounter()
	{
		try
		{
			using (StreamReader SR = new StreamReader(FilePath))
			{
				string line;
				while ((line = SR.ReadLine()) != null)
				{
					string[] words = line.Split(new char[] { ' ', '.', ',', '!', '?', ';', ':','(',')','{','}' }, StringSplitOptions.RemoveEmptyEntries);


					for (int i = 0; i < words.Length; i++)
					{
						if (words[i].Equals(word,StringComparison.OrdinalIgnoreCase))
						{
							Count++;
						}
					}
				}
			}
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
		return Count;
    }
	
}
