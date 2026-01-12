/*Recent Access Cache System
Use Case: Implement a cache where the most recently accessed entry
is kept at the front.
Why LinkedList? Allows quick insertion at front.
OOP Concepts:
● Encapsulation: Internal storage hidden
● Abstraction: Exposes read() and write() operations
● Composition: Uses LinkedList + Dictionary internally*/

using System;

public class CacheNode
{
    public int Id;
    public int Data;
    public CacheNode Link;

    public CacheNode(int id, int data)
    {
        Id = id;
        Data = data;
        Link = null;
    }
}

// Abstraction
public abstract class CacheBase
{
    public abstract int Read(int id);
    public abstract void Write(int id, int data);
}

public class RecentCache : CacheBase
{
    private CacheNode start;
    private Dictionary<int, CacheNode> lookup = new Dictionary<int, CacheNode>();
    private int limit = 3;

    public override int Read(int id)
    {
        if (!lookup.ContainsKey(id))
            return -1;

        return lookup[id].Data;
    }

    public override void Write(int id, int data)
    {
        if (lookup.Count == limit)
        {
            Console.WriteLine("Cache limit reached, removing oldest entry");
            start = start.Link;
        }

        CacheNode node = new CacheNode(id, data);
        node.Link = start;
        start = node;
        lookup[id] = node;
    }
}
