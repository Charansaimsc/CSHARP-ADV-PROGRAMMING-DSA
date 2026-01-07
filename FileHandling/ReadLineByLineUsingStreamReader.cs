using System;

public class FileLineReader
{
	private string FilePath;
	public FileLineReader(string FilePath)
	{
		this.FilePath = FilePath;
	}
	public void ReadLineByLine()
	{
		try
		{
			using(StreamReader SR = new StreamReader(FilePath))
			{
				string line;
				while ((line = SR.ReadLine()) != null)
				{
					Console.WriteLine(line);
				}
			}
		}
		catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
