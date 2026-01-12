using System;
namespace stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            IExpressionEvaluator evaluator;

            evaluator = new PostfixEvaluator();
            Console.WriteLine(evaluator.Evaluate("3 5 2 * +")); 

            evaluator = new PrefixEvaluator();
            Console.WriteLine(evaluator.Evaluate("+ 3 * 5 2"));
        }
    }
}