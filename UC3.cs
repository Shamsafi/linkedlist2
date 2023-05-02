//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linked_List
//{
//    public class UC3
//    {
//        public class Node
//        {
//            public int data;
//            public Node next;
//            public Node(int data)
//            {
//                this.data = data;
//            }
//        }

//        public class Linked_List2
//        {
//            private Node head;

//            public bool Add(int data)
//            {
//                Node n = new Node(data);   //node object will be created
//                if (head == null)
//                {
//                    head = n;
//                    return true;
//                }
//                n.next = head;
//                head = n;
//                return true;
//            }

//            public bool Append(int data)
//            {
//                Node n = new Node(data);
//                if (head == null)
//                {
//                    head = n;
//                    return true;
//                }

//                Node t = head;
//                while (t.next != null)
//                {
//                    t = t.next;
//                }
//                t.next = n; //Which t.next is this?
//                return true;
//            }

//            public void Print()
//            {
//                Node t = head;
//                while (t != null)
//                {
//                    Console.WriteLine(t.data);
//                    t = t.next;
//                }
//            }
//        }

//        static void Main(string[] args)
//        {
//            Linked_List2 list = new Linked_List2();
//            list.Add(56);
//            list.Append(30);
//            list.Append(70);
//            list.Print();
//            Console.ReadKey();
//        }

//    }
//}
