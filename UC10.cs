using System;

public class Node
{
    public int data;
    public Node next;
    public Node(int d)
    {
        data = d;
        next = null;
    }
}

public class LinkedList
{
    public Node head;
    public LinkedList()
    {
        head = null;
    }
    public void Insert(int data)
    {
        Node newNode = new Node(data);
        if (head == null || head.data >= newNode.data)
        {
            newNode.next = head;
            head = newNode;
        }
        else
        {
            Node current = head;
            while (current.next != null && current.next.data < newNode.data)
            {
                current = current.next;
            }
            newNode.next = current.next;
            current.next = newNode;
        }
    }
    public void PrintList()
    {
        Node current = head;
        while (current != null)
        {
            Console.Write(current.data + " ");
            current = current.next;
        }
        Console.WriteLine();
    }
}

public class Program
{
    public static void Main()
    {
        LinkedList list = new LinkedList();
        list.Insert(56);
        list.Insert(30);
        list.Insert(40);
        list.Insert(70);
        Console.WriteLine("Ordered linked list:");
        list.PrintList();
    }
}
