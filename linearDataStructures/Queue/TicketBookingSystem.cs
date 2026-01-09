/*Use Case: Ticket requests (flight, train) are processed in sequence.
OOP Concepts:
● Interface: TicketRequest
● Encapsulation: Request queue managed inside a service.
● Abstraction & Polymorphism: Works for bus/train/flight with common interface.
*/


using System;

public interface ITicketRequest
{
    void BookTicket();

}
public class flight : ITicketRequest
{
    public string name;
    public flight(string name)
    {
        this.name = name; 
    }
    public void BookTicket()
    {
        Console.WriteLine($"Booking the Ticket for Flight to : {name}");
    }
}
public class train : ITicketRequest
{
    public string name;
    public train(string name)
    {
        this.name = name;
    }
    public void BookTicket()
    {
        Console.WriteLine($"Booking ticket in train for {name}");
    }
}
public class Bus : ITicketRequest
{
    public string name;
    public Bus(string name)
    {
        this.name = name;
    }
    public void BookTicket()
    {
        Console.WriteLine($"booking ticket Bus for : {name}");
    }
}
public class BookingService
{
    private Queue<ITicketRequest> ticket = new Queue<ITicketRequest> ();
    public void Add(ITicketRequest request)
    {
        ticket.Enqueue(request);
        Console.WriteLine($"Ticket Added to list");
    }
    public void Next()
    {
        if(ticket.Count == 0)
        {
            Console.WriteLine("no tickets in queue");
            return;

        }
        ITicketRequest TR = ticket.Dequeue();
        TR.BookTicket();
    }
}
