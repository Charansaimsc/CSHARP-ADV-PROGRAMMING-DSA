using System;

public class SupportNode
{
    public string Info;
    public SupportNode Link;

    public SupportNode(string info)
    {
        Info = info;
        Link = null;
    }
}

public abstract class SupportQueueBase
{
    public abstract void Enqueue(string request);
    public abstract void Dequeue();
}

public class HelpDeskQueue : SupportQueueBase
{
    private SupportNode head, tail;

    public override void Enqueue(string request)
    {
        SupportNode node = new SupportNode(request);

        if (tail == null)
        {
            head = tail = node;
            return;
        }

        tail.Link = node;
        tail = node;
    }

    public override void Dequeue()
    {
        if (head == null)
        {
            Console.WriteLine("No requests available.");
            return;
        }

        Console.WriteLine("Processing : " + head.Info);
        head = head.Link;

        if (head == null)
            tail = null;
    }
}
