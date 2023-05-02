//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linked_List
//{
//    public class Node
//    {
//        public int data;
//        public Node next;
//        public Node(int data)
//        {
//            this.data = data;
//        }
//    }
//    public class LLSearch
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
//        public void Search(int value)
//        {
//            Node t = head;
//            bool con = false;
//            while (t != null)
//            {
//                if (t.data.Equals(value))
//                {
//                    con = true;
//                    Console.WriteLine("{0}is found", value);
//                }
//                t = t.next;
//            }
//            if (con == false)
//            { Console.WriteLine("{0}is not found", value); }
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
//            LLSearch list = new LLSearch();
//            list.insert(70);
//            list.insert(40);
//            list.insert(30);
//            list.insert(56);
//            list.Search(40);
//            list.display();
//        }
//    }
//}
