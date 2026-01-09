/*Use Case: Incoming calls are queued for available agents.
OOP Concepts:
● Interface: CallRequest
● Polymorphism: Calls could be SupportCall, SalesCall, etc.
● Encapsulation: Queue handling hidden inside CallCenterManager.*/


using System;
using System.Collections.Generic;

public interface ICallRequest
{
    void HandleCall();
}


public class SupportCall : ICallRequest
{
    private string customerName;

    public SupportCall(string customerName)
    {
        this.customerName = customerName;
    }

    public void HandleCall()
    {
        Console.WriteLine($"Handling SUPPORT call for {customerName}");
    }
}
public class SalesCall : ICallRequest
{
    private string customerName;

    public SalesCall(string customerName)
    {
        this.customerName = customerName;
    }

    public void HandleCall()
    {
        Console.WriteLine($"Handling SALES call for {customerName}");
    }
}


public class CallCenterManager
{
    private Queue<ICallRequest> callQueue = new Queue<ICallRequest>();

    public void AddCall(ICallRequest call)
    {
        callQueue.Enqueue(call);
        Console.WriteLine("Incoming call added to queue");
    }

    public void HandleNextCall()
    {
        if (callQueue.Count == 0)
        {
            Console.WriteLine("No calls waiting");
            return;
        }

        ICallRequest call = callQueue.Dequeue();
        call.HandleCall();  
    }
}

