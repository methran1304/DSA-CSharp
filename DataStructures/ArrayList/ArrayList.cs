using System.Collections;
using System.Runtime.CompilerServices;

namespace DS;

public class ArrayListImplemtation<T> : IEnumerable<T>
{
    private T[] Values;
    public uint Length { get; private set; } = 0;
    public uint Capacity { get; private set; } = 4;

    public ArrayListImplemtation()
    {
        Values = new T[Capacity];
    }

    public void Push(T value)
    {
        if (Length >= Capacity)
        {
            Expand();
        }

        Values[Length++] = value;
    }

    public void Pop()
    {
        if (Length == 0)
        {
            return;
        }

        Length--;
    }

    public bool IsEmpty()
    {
        return Length == 0;
    }

    private void Expand()
    {
        uint newCapacity = Capacity * 2;
        T[] valuesCopy = new T[newCapacity];

        for (int i = 0; i < Capacity; i++)
        {
            valuesCopy[i] = Values[i];
        }

        Values = valuesCopy;
        Capacity = newCapacity;
    }

    public IEnumerator<T> GetEnumerator()
    {
        for (uint i = 0; i < Length; i++)
        {
                yield return Values[i];
        }
    }

    IEnumerator IEnumerable.GetEnumerator()
    {
        return GetEnumerator();
    }

    public T? this[int index]
    {
        get => (index >= Length) ? default : Values[index];
        set => Values[index] = value!;
    }
}


public static class ArrayList
{
    public static void Begin()
    {
        ArrayListImplemtation<int> x = new();

        x.Push(1);
        x.Push(2);
        x.Push(3);
        x.Push(41);
        x.Push(5);


        foreach (int element in x)
        {
            Console.WriteLine(element);
        }

        Console.WriteLine();

        x.Pop();

        foreach (int element in x)
        {
            Console.WriteLine(element);
        }
    }
}
