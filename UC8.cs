//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linked_List
//{    //insert in middle
//    public class Node
//    {
//        public int data;
//        public Node next;
//        public Node(int data)
//        {
//            this.data = data;
//        }
//    }
//    public class LLInsertMiddle
//    {
//        Node head;
//        public void insert(int data)  // 56 30 70
//        {
//            Node n = new Node(data);
//            if (head == null)
//            {
//                head = n;
//            }
//            else
//            {
//                n.next = head;
//                head = n;
//            }
//        }
//        public void Middle(int data, int key)
//        {
//            Node t = head;
//            Node n = new Node(data);
//            while (t != null)
//            {
//                if (t.data.Equals(key))
//                {
//                    n.next = t.next;
//                    t.next = n;
//                }
//                t = t.next;
//            }
//        }
//        public void display()
//        {
//            Node temp = head;
//            while (temp != null)
//            {
//                Console.Write(temp.data + " ");
//                temp = temp.next;
//            }
//        }

//        static void Main()
//        {
//            LLInsertMiddle list = new LLInsertMiddle();
//            list.insert(70);
//            //list.insert(40);
//            list.insert(30);
//            list.insert(56);
//            list.display();
//            list.Middle(40, 30);
//            list.display();


//        }
//    }
//}
