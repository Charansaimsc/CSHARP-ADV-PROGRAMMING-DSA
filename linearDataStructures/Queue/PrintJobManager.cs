using System;

public interface IPrintable
{
    void Print();
}
public class XeroxPaper : IPrintable
{
    private string paper;
    public XeroxPaper(string paper)
    {
       this.paper = paper; 
    }
    public void Print()
    {
        Console.WriteLine($"printing Xerox: {paper}");

    }
}
public class Photo : IPrintable
{
    private string Photos;
    public Photo(string Photos)
    {
        this.Photos = Photos;
    }
    public void Print()
    {
        Console.WriteLine($"Printing photo:{Photos}");
 
   }
}
public class Print
{
    private Queue<IPrintable> queue = new Queue<IPrintable>();

    public void Add(IPrintable p)
    {
        queue.Enqueue(p);
        Console.WriteLine("tsk added");
    }
    public void Next()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("emplty");
            return;
        }

        IPrintable P = queue.Dequeue();
        P.Print();
    }
}