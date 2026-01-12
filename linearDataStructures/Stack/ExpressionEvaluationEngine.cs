using System;
using System.Collections.Generic; 

public interface IExpressionEvaluator
{
    int Evaluate(string expression);
}


public class PostfixEvaluator : IExpressionEvaluator
{
    public int Evaluate(string expression)
    {
        Stack<int> stack = new Stack<int>();
        string[] tokens = expression.Split(' ');

        foreach (string token in tokens)
        {
            if (int.TryParse(token, out int number))
            {
                stack.Push(number);
            }
            else
            {
                int b = stack.Pop();
                int a = stack.Pop();

                int result = token switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" => a / b,
                    _ => throw new InvalidOperationException("Invalid operator")
                };

                stack.Push(result);
            }
        }
        return stack.Pop();
    }
}


public class PrefixEvaluator : IExpressionEvaluator
{
    public int Evaluate(string expression)
    {
        Stack<int> stack = new Stack<int>();
        string[] tokens = expression.Split(' ');

        for (int i = tokens.Length - 1; i >= 0; i--)
        {
            if (int.TryParse(tokens[i], out int number))
            {
                stack.Push(number);
            }
            else
            {
                int a = stack.Pop();
                int b = stack.Pop();

                int result = tokens[i] switch
                {
                    "+" => a + b,
                    "-" => a - b,
                    "*" => a * b,
                    "/" => a / b,
                    _ => throw new InvalidOperationException("Invalid operator")
                };

                stack.Push(result);
            }
        }
        return stack.Pop();
    }
}
