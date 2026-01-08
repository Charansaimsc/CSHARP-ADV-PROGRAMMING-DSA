using System;
public class Navigation
{
    public string url {  get; }
    public Navigation Previous { get; set; }
    public Navigation Next { get; set; }
    public Navigation(string url)
    {
        this.url = url; 
    }
}
public abstract class NavigationHistory
{
    protected Navigation current;
    public abstract void Visit(string item);
    public abstract string Back();
    public abstract string Forward();
    public string Current()
    {
        return current != null ? current.url : "no history";

    }
}

public class BrowserHistory : NavigationHistory
{
    public override void Visit(string url)
    {
        Navigation newitem = new Navigation(url);
        if (current != null)
        {
            current.Next = null;
            newitem.Previous = current;
            current.Next = newitem;
        }
        current = newitem;

    }
    public override string Back()
    {
        if(current?.Previous == null)
        {
            return "no previous page";
        }
        current = current.Previous;
        return current.url;
    }
    public override string Forward()
    {
        if(current?.Next == null)
        {
            return "no next page";
        }
        current = current.Next;
        return current.url;
    }
}