namespace DS;

public class LLImplementation<T>
{
    private class Node
    {
        public T? Value { get; set; }
        public Node? NextNode { get; set; }
        public Node(T? Value)
        {
            this.Value = Value;
            NextNode = null;
        }
    }

    private Node Head { get; set; }
    public uint Count { get; set; }


    public LLImplementation()
    {
        Head = new(default(T));
        Count = 0;
    }

    public void InsertAtEnd(T Value)
    {
        Node newNode = new(Value);

        if (Count == 0)
        {
            Head = newNode; // first node in the linked list
        }
        else
        {
            // find last node and set NextNode to new node
            Node tempNode = Head;
            while (tempNode.NextNode != null)
            {
                tempNode = tempNode.NextNode;
            }
            tempNode.NextNode = newNode;
        }

        Count++;
    }

    public void Traverse()
    {
        if (Head == null)
            return;

        Node? tempNode = Head;

        while (tempNode != null)
        {
            Console.Write(tempNode.Value);
            if (!IsLastNode(tempNode))
            {
                Console.Write(" -> ");
            }
            tempNode = tempNode.NextNode;
        }

        Console.Write('\n');
    }

    private bool IsLastNode(Node node) => node.NextNode == null;
}

public static class LinkedList
{
    public static void Begin()
    {
        LLImplementation<int> myList = new();
        Console.WriteLine($"myList length: {myList.Count}");

        myList.InsertAtEnd(1);
        Console.WriteLine($"myList length after insertion 1: {myList.Count}");
        Console.WriteLine("myList after insertion 1");
        myList.Traverse();

        myList.InsertAtEnd(2);
        Console.WriteLine($"myList length after insertion 2: {myList.Count}");
        Console.WriteLine("myList after insertion 2");
        myList.Traverse();

        for (int i = 3; i <= 10; i++)
        {
            myList.InsertAtEnd(i);
        }

        Console.WriteLine($"myList length after multiple insertion: {myList.Count}");
        Console.WriteLine("myList after multiple insertion");
        myList.Traverse();
        

        // TODO: Insert at middle, deletion by index, element (can be used for deleteFirst, deleteLast), findByElement, findByIndex
    }
}
