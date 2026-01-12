/*Task Processing System with Runnable Interface
Use Case: Background engine that processes tasks like sync, notifications, maintenance, etc.
OOP Concepts:
● Interface: Runnable enables multiple task types.
● LinkedList: Maintains task pipeline.
● Abstraction & Polymorphism: Run method is common, implementation differs.*/

using System;

// Interface
public interface IRunnable
{
    void Run();
}

public class SyncTask : IRunnable
{
    public void Run()
    {
        Console.WriteLine("Executing Sync Task");
    }
}

public class MailTask : IRunnable
{
    public void Run()
    {
        Console.WriteLine("Dispatching Mail Task");
    }
}

public class MaintenanceTask : IRunnable
{
    public void Run()
    {
        Console.WriteLine("Running Maintenance Task");
    }
}

public class TaskNode
{
    public IRunnable Item;
    public TaskNode Next;

    public TaskNode(IRunnable item)
    {
        Item = item;
        Next = null;
    }
}

public class TaskQueue
{
    private TaskNode head, tail;

    public void Enqueue(IRunnable task)
    {
        TaskNode node = new TaskNode(task);

        if (tail == null)
        {
            head = tail = node;
            return;
        }

        tail.Next = node;
        tail = node;
    }

    public void ProcessAll()
    {
        while (head != null)
        {
            head.Item.Run();
            head = head.Next;
        }
    }
}
