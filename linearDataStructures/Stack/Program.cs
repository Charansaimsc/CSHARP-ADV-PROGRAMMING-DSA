using System;
namespace stack
{
    public class Program
    {
        static void Main(string[] args)
        {
            //IExpressionEvaluator evaluator;

            //evaluator = new PostfixEvaluator();
            //Console.WriteLine(evaluator.Evaluate("3 5 2 * +"));

            //evaluator = new PrefixEvaluator();
            //Console.WriteLine(evaluator.Evaluate("+ 3 * 5 2"));


            //INavigationManager Browser;
            //Browser = new Desktop("land8form.com");
            //Browser.Navigate("gla.ac.in");
            //Browser.Navigate("BinaryBridge.com");
            //Browser.Navigate("helloWorld.com");
            //Browser.Back();
            //Browser.Back();
            //Browser.Back();
            //Browser.Forward();
            //Browser.Display();


            //ISyntaxChecker Syntaxer;
            //Syntaxer = new CodeSyntax();
            //Console.WriteLine(Syntaxer.IsValid("{{}}{{}}((())"));

            //Console.WriteLine(Syntaxer.IsValid("((())){{}}[[]]"));



            DrawingApp app = new DrawingApp();
            app.Draw(new DrawLine());
            app.Draw(new DrawCircle());
            app.Draw(new Erase());
            app.Undo(); 
            app.Undo(); 
            app.Undo(); 
            app.Undo();



















        }
    }
}