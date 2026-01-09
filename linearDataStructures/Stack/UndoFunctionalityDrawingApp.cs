using System;
using System.Collections.Generic;

public interface IDrawingAction
{
    void Execute();
    void Undo();
}
public class DrawLine : IDrawingAction
{
    public void Execute()
    {
        Console.WriteLine("LineDrawn");
    }
    public void Undo()
    {
        Console.WriteLine("Line removed ");

    }
}
public class DrawCircle : IDrawingAction
{
    public void Execute()
    {
        Console.WriteLine("circleDrawn");

    }
    public void Undo() 
    {
        Console.WriteLine("circle removed");
    }
}
public class Erase : IDrawingAction
{
    public void Execute()
    {
        Console.WriteLine("Erased");
    }
    public void Undo()
    {
        Console.WriteLine("Restored");
    }
}


public class DrawingApp
{
    private Stack<IDrawingAction> undoStack = new Stack<IDrawingAction>();

    public void Draw(IDrawingAction Drawing)
    {
        Drawing.Execute();
        undoStack.Push(Drawing);
    }

    public void Undo()
    {
        if (undoStack.Count == 0)
        {
            Console.WriteLine("Nothing to undo");
            return;
        }

        IDrawingAction last = undoStack.Pop();
        last.Undo();
    }
}
