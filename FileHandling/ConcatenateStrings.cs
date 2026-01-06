using System;
using System.Text;
public class ConcatenateString
{
	private string[] _strings;
	public ConcatenateString(string[]  _strings)
	{
		this._strings = _strings;
	}
	public string Concatenate()
	{
		StringBuilder Sb = new StringBuilder();
		for (int i = 0; i < _strings.Length; i++)
		{
			Sb.Append(_strings[i]);
		}
		return Sb.ToString();

	}
}
