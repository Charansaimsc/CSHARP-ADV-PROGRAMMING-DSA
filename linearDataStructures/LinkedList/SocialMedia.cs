/*User Activity Feed System
Use Case: Maintain and show recent user activities in reverse order
(latest activity first).
Why LinkedList? Enables fast insertion at the front and easy traversal.
OOP Concepts:
● Encapsulation: Activity feed managed internally
● Abstraction: Simple addEntry() and showFeed() interface
● Inheritance/Polymorphism: Different activity types handled uniformly*/

using System;

public class ActivityNode
{
    public string Content;
    public ActivityNode Link;

    public ActivityNode(string content)
    {
        Content = content;
        Link = null;
    }
}

// Abstraction
public abstract class ActivityFeed
{
    public abstract void AddEntry(string content);
    public abstract void ShowFeed();
}

public class ProfileFeed : ActivityFeed
{
    private ActivityNode start;

    public override void AddEntry(string content)
    {
        ActivityNode node = new ActivityNode(content);
        node.Link = start;
        start = node;
    }

    public override void ShowFeed()
    {
        ActivityNode current = start;
        while (current != null)
        {
            Console.WriteLine(current.Content);
            current = current.Link;
        }
    }
}
