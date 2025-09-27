using System.Collections;

namespace DS;

public class StackImplementation<T>
{
    private LLImplementation<T> Values { get; set; }
    public uint Count => Values.Count;

    public StackImplementation()
    {
        Values = new();
    }

    public bool Push(T value)
    {
        Values.InsertAtHead(value);
        return true;
    }

    public bool Pop()
    {
        T? top = Values.GetHead();
        Values.DeleteAtHead();
        return top != null;
    }

    public T? Peek()
    {
        return Values.GetHead();
    }

    public uint GetSize()
    {
        return Values.Count;
    }

    public void Traverse()
    {
        Console.Write("Top -> ");
        foreach (T element in Values)
        {
            Console.Write($"{element} ");
        }
        Console.Write('\n');
    }
}

public static class Stack
{
    public static void Begin()
    {
        StackImplementation<int> s = new();
        s.Traverse();

        s.Push(1);
        s.Push(2);
        s.Push(3);
        s.Push(4);
        s.Push(5);

        s.Traverse();

        s.Pop();

        s.Traverse();
    }
}
