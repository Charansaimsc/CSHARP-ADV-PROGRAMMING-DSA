/*Problem: Write a program that uses StringBuilder to reverse a given string. For example, if
the input is "hello", the output should be "olleh".*/
using System;
using System.Text;
public class ReverseString
{
	private string _value;
	public ReverseString(string _value)
	{
		this._value = _value; 
	}
	public string Reverse()
	{
		StringBuilder sb = new StringBuilder();
		
			for (int i = _value.Length - 1; i >= 0; i--)
			{
		
				sb.Append(_value[i]);
			}
			return sb.ToString();
	}
}
