//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Linked_List
//{  //Dlelet Last Element
//    public class Node
//    {
//        public int data;
//        public Node next;
//        public Node(int data)
//        {
//            this.data = data;
//        }
//    }
//    public class LLPop
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

//        public void Pop()// 56 30 40 
//        {
//            if (head == null)
//                throw new NullReferenceException("list is empty");
//            Node t = head, prev = null;
//            while (t.next != null)
//            {
//                prev = t;
//                t = t.next;
//            }
//            prev.next = null;
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
//            LLPop list = new LLPop();
//            list.insert(40);
//            list.insert(30);
//            list.insert(56);
//            list.Pop();
//            list.display();

//        }
//    }
//}
