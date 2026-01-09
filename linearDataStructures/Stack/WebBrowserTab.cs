using System;
using System.Collections.Generic;
public interface INavigationManager
{
    void Navigate(string url);
    void Back();
    void Forward();
    void Display();
}
public class Desktop : INavigationManager
{
    private Stack<string> backStack = new Stack<string>();
    private Stack<string> forwardStack = new Stack<string>();
    private string current;
         public Desktop(string current)
         {
            this.current = current;
            Console.WriteLine($"Opened:{current}");

         }
     public void Navigate(string url)
{
    backStack.Push(current);
    current = url;
    forwardStack.Clear();
    Console.WriteLine($"Navigated to:{current}");

}
public void Back() 
{ 
    if(backStack.Count == 0)
    {
        return;
    }
    forwardStack.Push(current);
    current = backStack.Pop();
    Console.WriteLine($"BACK TO :{current}");
}
public void Forward()
{
    if(forwardStack.Count == 0)
    {
        return;
    }
    backStack.Push(current);
    current = forwardStack.Pop();
    Console.WriteLine($"Forward to: {current}");
}
public void Display()
{
    Console.WriteLine($"Current Page: {current}");
}
}