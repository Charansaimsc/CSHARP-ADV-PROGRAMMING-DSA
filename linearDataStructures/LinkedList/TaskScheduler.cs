/*Priority-Based Job Scheduler

Use Case: Schedule jobs dynamically based on priority.
Why LinkedList? Allows insertion at appropriate position by priority.
OOP Concepts:
● Encapsulation: Job data handled internally
● Abstraction: Hides priority insertion logic
● Polymorphism: Different job types can be treated uniformly*/

using System;

public class JobNode
{
    public int Level;
    public string Title;
    public JobNode Link;

    public JobNode(string title, int level)
    {
        Title = title;
        Level = level;
        Link = null;
    }
}

// Abstraction
public abstract class JobScheduler
{
    public abstract void InsertJob(string title, int level);
    public abstract void RunJob();
}

public class OrderedJobScheduler : JobScheduler
{
    private JobNode start;

    public override void InsertJob(string title, int level)
    {
        JobNode node = new JobNode(title, level);

        if (start == null || level < start.Level)
        {
            node.Link = start;
            start = node;
            return;
        }

        JobNode current = start;
        while (current.Link != null && current.Link.Level <= level)
            current = current.Link;

        node.Link = current.Link;
        current.Link = node;
    }

    public override void RunJob()
    {
        if (start == null)
        {
            Console.WriteLine("No Jobs Available...");
            return;
        }

        Console.WriteLine("Running : " + start.Title);
        start = start.Link;
    }
}
