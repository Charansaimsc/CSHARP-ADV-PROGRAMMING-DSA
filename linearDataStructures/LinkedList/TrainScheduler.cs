using System;

public class StopNode
{
    public string Label;
    public StopNode Link;

    public StopNode(string label)
    {
        Label = label;
        Link = null;
    }
}

// Abstraction
public abstract class Path
{
    public abstract void InsertStop(string label);
    public abstract void DeleteStop();
    public abstract void ReversePath();
    public abstract void DisplayPath();
}

public class RailPath : Path
{
    private StopNode start;

    public override void InsertStop(string label)
    {
        StopNode node = new StopNode(label);

        if (start == null)
        {
            start = node;
            return;
        }

        StopNode temp = start;
        while (temp.Link != null)
            temp = temp.Link;

        temp.Link = node;
    }

    public override void DeleteStop()
    {
        if (start == null) return;

        if (start.Link == null)
        {
            start = null;
            return;
        }

        StopNode temp = start;
        while (temp.Link.Link != null)
            temp = temp.Link;

        temp.Link = null;
    }

    public override void ReversePath()
    {
        StopNode prev = null, current = start, next = null;

        while (current != null)
        {
            next = current.Link;
            current.Link = prev;
            prev = current;
            current = next;
        }

        start = prev;
    }

    public override void DisplayPath()
    {
        StopNode temp = start;
        while (temp != null)
        {
            Console.Write(temp.Label + " --> ");
            temp = temp.Link;
        }
        Console.WriteLine("End....");
    }
}
