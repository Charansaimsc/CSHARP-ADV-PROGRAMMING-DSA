/* Convert Byte Stream to Character Stream Using StreamReader
Problem: Write a program that uses StreamReader to read binary data from a file and print
it as characters.
*/
using System;
using System.IO;
using System.Text;

public class ByteToChar
{
	private readonly string FilePath;
	public ByteToChar(string FilePath)
	{
		this.FilePath = FilePath;
	}
	public void ByteToCharacter()
	{
		try
		{
			using(FileStream FS = new FileStream(FilePath, FileMode.Open, FileAccess.Read)) 
			{ 
				using(StreamReader SR= new StreamReader(FS,Encoding.UTF8))
				{
						string content = SR.ReadToEnd();
					Console.WriteLine(content);
						
				}
			}
		}catch (Exception e)
		{
			Console.WriteLine(e.Message);
		}
	}
}
