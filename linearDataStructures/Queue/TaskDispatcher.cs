/*Use Case: Queue tasks like file uploads, analytics, or logs to background workers.
OOP Concepts:
● Interface: BackgroundTask
● Encapsulation: TaskQueue shields queue logic.
● Polymorphism: Different tasks (upload, report) use same interface.*/
using System;
using System.Collections.Generic;


public interface IBackGroundTask
{
    void Execute();
}
public class Upload : IBackGroundTask
{
    public string FileName;
    public Upload(string FileName)
    {
        this.FileName = FileName; 
    }
    public void Execute() 
    {
        Console.WriteLine($"FileUploading : {FileName}");
    }
}
public class Report : IBackGroundTask
{
    public string FileName;
    public Report(string FileName)
    {
        this.FileName = FileName;
    }
    public void Execute()
    {
        Console.WriteLine($"Getting Back WIth report : {FileName}");
    }
}
public class PriorityTask
{
    private Queue<IBackGroundTask> queue = new Queue<IBackGroundTask>();
    public void Add(IBackGroundTask task)
    {
        queue.Enqueue(task);
        Console.WriteLine("Task added to list of tasks to be executed");
    }
    public void Next()
    {
        if (queue.Count == 0)
        {
            Console.WriteLine("no tasks in queue");
            return;
        }
        IBackGroundTask task = queue.Dequeue();
        task.Execute();
    }
}