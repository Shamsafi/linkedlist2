using System;
namespace Linked_List
{
    public class Program
    {
        public class Node
        {
            public int data;
            public Node next;
            public Node(int data)
            {
                this.data = data;
            }
        }

        public class Linked_List
        {
            private Node head;

            public bool Add(int data)
            {
                Node n = new Node(data);
                if (head == null)
                {
                    head = n;
                    return true;
                }
                n.next = head;
                head = n;
                return true;
            }

            public void Print()
            {
                Node t = head;
                while (t != null)
                {
                    Console.WriteLine(t.data);
                    t = t.next;
                }
            }
        }

        static void Main(string[] args)
        {
            Linked_List list = new Linked_List();
            list.Add(56);
            list.Add(30);
            list.Add(70);
            list.Print();
            Console.ReadKey();
        }
    }
}