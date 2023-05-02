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

//    public void AddNode(int data)
//    {
//        Node newNode = new Node(data);

//        if (head == null)
//        {
//            head = newNode;
//            return;
//        }

//        Node lastNode = head;
//        while (lastNode.next != null)
//        {
//            lastNode = lastNode.next;
//        }

//        lastNode.next = newNode;
//    }

//    public void PrintList()
//    {
//        Node currentNode = head;

//        while (currentNode != null)
//        {
//            Console.Write(currentNode.data + " ");
//            currentNode = currentNode.next;
//        }
//        Console.WriteLine();
//    }
//}

//public class Program
//{
//    public static void Main()
//    {
//        LinkedList list = new LinkedList();

//        Node node70 = new Node(70);
//        Node node30 = new Node(30);
//        Node node56 = new Node(56);

//        node70.next = node30;
//        node30.next = node56;

//        list.head = node70;

//        list.PrintList();
//    }
//}
