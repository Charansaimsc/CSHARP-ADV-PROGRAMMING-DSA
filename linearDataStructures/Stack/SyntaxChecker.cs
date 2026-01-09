/*Use Case: Validate matched parentheses, brackets, or braces ({}, [], ()).
OOP Concepts:
● Interface: SyntaxChecker
● Encapsulation: Stack logic is hidden inside the implementation.
● Polymorphism: Can create multiple syntax checkers for different file types.*/
using System;

public interface ISyntaxChecker
{
    bool IsValid(string input);
}
public class CodeSyntax : ISyntaxChecker
{
    private Stack<char> stack = new Stack<char>();
    public bool IsValid(string input)
    {
        stack.Clear();
        for (int i = 0; i < input.Length; i++) 
        {
            if (input[i] == '(' || input[i] == '{' || input[i] == '[')
            {
                stack.Push(input[i]);
            }
            else if (input[i] == ']' || input[i] == '}' || input[i] == ')')
            {
                if (stack.Count == 0)
                {
                    return false;
                }
                char top = stack.Pop();
                if (!IsMatchingPair(top, input[i]))
                {
                    return false;
                }
            }
            }
            return stack.Count == 0;
        }
        private bool IsMatchingPair(char open,char close)
        {
        return (open == '(' && close ==')') || (open == '{' && close == '}')|| (open == '[' && close ==']');
         }
    
}