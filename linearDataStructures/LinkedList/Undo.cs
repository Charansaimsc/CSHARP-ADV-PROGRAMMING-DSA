/*Scenario: Revert Feature in Editor
Use Case: Each modification is saved and can be reverted step-by-step.
Why LinkedList? LIFO behavior matches stack implemented using LinkedList.
OOP Concepts:
● Encapsulation: Each modification stored as a snapshot
● Abstraction: Revert operation hides internal stack logic
● Inheritance: Snapshot can act as base for other editor modes*/

using System;

public class ChangeNode
{
    public string Content;
    public ChangeNode Link;

    public ChangeNode(string content)
    {
        Content = content;
        Link = null;
    }
}

// Abstraction
public abstract class RevertFeature
{
    public abstract void Revert();
}

public class EditorEngine : RevertFeature
{
    private ChangeNode head;

    public void Insert(string content)
    {
        ChangeNode node = new ChangeNode(content);
        node.Link = head;
        head = node;
    }

    public override void Revert()
    {
        if (head == null)
        {
            Console.WriteLine("No changes to revert");
            return;
        }

        Console.WriteLine("Reverted: " + head.Content);
        head = head.Link;
    }
}
