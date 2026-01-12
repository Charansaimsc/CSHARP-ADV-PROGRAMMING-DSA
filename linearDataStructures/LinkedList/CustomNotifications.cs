/*Custom Alert System with Interface and LinkedList
Use Case: Dispatch alerts of different types (Mail, Text, App) and store them in a
processing queue.
OOP Concepts:
● Interface: Alert interface represents all types.
● Polymorphism: Each alert type handles dispatch differently.
● Encapsulation: AlertQueue hides internal structure.
● Abstraction: Only enqueue() and dispatchAll() methods are exposed.*/

using System;

// Interface
public interface IAlert
{
    void Dispatch();
}

public class MailAlert : IAlert
{
    public void Dispatch()
    {
        Console.WriteLine("Mail Alert Dispatched");
    }
}

public class TextAlert : IAlert
{
    public void Dispatch()
    {
        Console.WriteLine("Text Alert Dispatched");
    }
}

public class AppAlert : IAlert
{
    public void Dispatch()
    {
        Console.WriteLine("App Alert Dispatched");
    }
}

public class AlertNode
{
    public IAlert Payload;
    public AlertNode Link;

    public AlertNode(IAlert payload)
    {
        Payload = payload;
        Link = null;
    }
}

public class AlertQueue
{
    private AlertNode head, tail;

    public void Enqueue(IAlert alert)
    {
        AlertNode node = new AlertNode(alert);

        if (tail == null)
        {
            head = tail = node;
            return;
        }

        tail.Link = node;
        tail = node;
    }

    public void DispatchAll()
    {
        while (head != null)
        {
            head.Payload.Dispatch();
            head = head.Link;
        }
    }
}
