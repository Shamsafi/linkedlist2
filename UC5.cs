//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linked_List
//{   //Delete First Element
//    public class Node
//    {
//        public int data;
//        public Node next;
//        public Node(int data)
//        {
//            this.data = data;
//        }
//    }
//    public class LLPopFirst
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

//        public void PopFirst()// 56 30 40 70
//        {
//            Node t = head;
//            if (t == null)
//            { throw new NullReferenceException("list is empty"); }
//            else
//            {
//                head = t.next;
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
//            LLPopFirst list = new LLPopFirst();
//            list.insert(70);
//            list.insert(30);
//            list.insert(56);
//            list.PopFirst();
//            list.display();

//        }
//    }
//}
