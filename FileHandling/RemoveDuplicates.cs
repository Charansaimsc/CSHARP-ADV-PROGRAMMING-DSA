using System;
using System.Text;
public class RemoveDuplicatesUsingStringBuilder
{
	private string word;
	public RemoveDuplicatesUsingStringBuilder(string word)
	{
		this.word = word; 
	}
	public string removeDuplicates()
	{
		StringBuilder Sb = new StringBuilder();
		for (int i = 0; i < word.Length; i++)
		{
			if (!Sb.ToString().Contains(word[i]))
			{
				Sb.Append(word[i]);
			}
		}
		return Sb.ToString();
	}
}
