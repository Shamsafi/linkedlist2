//using System;

//public class Node
//{
//    public int data;
//    public Node next;
//    public Node(int d)
//    {
//        data = d;
//        next = null;
//    }
//}

//public class LinkedList
//{
//    public Node head;
//    public LinkedList()
//    {
//        head = null;
//    }
//    public void Insert(int data)
//    {
//        Node newNode = new Node(data);
//        if (head == null)
//        {
//            head = newNode;
//        }
//        else
//        {
//            Node current = head;
//            while (current.next != null)
//            {
//                current = current.next;
//            }
//            current.next = newNode;
//        }
//    }
//    public void Delete(int key)
//    {
//        Node current = head;
//        Node prev = null;
//        while (current != null && current.data != key)
//        {
//            prev = current;
//            current = current.next;
//        }
//        if (current == null)
//        {
//            Console.WriteLine("Key not found in the linked list");
//        }
//        else if (prev == null)
//        {
//            head = current.next;
//        }
//        else
//        {
//            prev.next = current.next;
//        }
//    }
//    public int Size()
//    {
//        int count = 0;
//        Node current = head;
//        while (current != null)
//        {
//            count++;
//            current = current.next;
//        }
//        return count;
//    }
//    public void PrintList()
//    {
//        Node current = head;
//        while (current != null)
//        {
//            Console.Write(current.data + " ");
//            current = current.next;
//        }
//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        LinkedList list = new LinkedList();
//        list.Insert(56);
//        list.Insert(30);
//        list.Insert(40);
//        list.Insert(70);
//        Console.WriteLine("Original linked list:");
//        list.PrintList();
//        list.Delete(40);
//        Console.WriteLine("Linked list after deleting 40:");
//        list.PrintList();
//        Console.WriteLine("Size of linked list: " + list.Size());
//    }
//}
