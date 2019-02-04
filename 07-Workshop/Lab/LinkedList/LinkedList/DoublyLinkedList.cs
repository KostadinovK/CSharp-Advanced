
using System;
using System.Resources;

public class DoublyLinkedList<T>
{
    private class Node
    {
        public T Value { get; set; }
        public Node Previous { get; set; }
        public Node Next { get; set; }

        public Node(T value)
        {
            Value = value;
            Previous = null;
            Next = null;
        }
    }

    private Node head;
    private Node tail;

    public int Count { get; set; }

    public DoublyLinkedList()
    {
        head = null;
        tail = null;
        Count = 0;
    }

    public DoublyLinkedList(T value)
    {
        head = new Node(value);
        tail = head;
        Count = 1;
    }


    public void AddFirst(T value)
    {
        if (Count == 0)
        {
            head = new Node(value);
            tail = head;
  
        }
        else
        {
            Node oldHead = head;
            head = new Node(value);
            head.Next = oldHead;
            oldHead.Previous = head;
        }

        Count++;
    }

    public void AddLast(T value)
    {
        if (Count == 0)
        {
            head = new Node(value);
            tail = head;

        }
        else
        {
            Node oldTail = tail;
            tail = new Node(value);
            tail.Previous = oldTail;
            oldTail.Next = tail;
        }

        Count++;
    }

    public void RemoveFirst()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Cannot remove from an empty list!");
        }

        if (Count == 1)
        {
            head = tail = null;
        }
        else
        {
            Node newHead = head.Next;
            head.Next = null;
            head = newHead;
            head.Previous = null;
        }

        Count--;
    }

    public void RemoveLast()
    {
        if (Count == 0)
        {
            throw new InvalidOperationException("Cannot remove from an empty list!");
        }

        if (Count == 1)
        {
            head = tail = null;
        }
        else
        {
            Node newTail = tail.Previous;
            tail.Previous = null;
            tail = newTail;
            tail.Next = null;
        }

        Count--;
    }

    public void ForEach(Action<T> action)
    {
        Node current = head;
        while (current != null)
        {
            action(current.Value);
            current = current.Next;
        }
    }

    public T[] ToArray()
    {
        T[] arr = new T[Count];

        Node current = head;
        int index = 0;

        while (current != null)
        {
            arr[index] = current.Value;
            index++;
            current = current.Next;
        }

        return arr;
    }
}

