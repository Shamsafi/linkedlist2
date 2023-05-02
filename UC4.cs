//using System;
//using System.Collections.Generic;
//using System.Linq;
//using System.Text;
//using System.Threading.Tasks;

//namespace Stack_Q_LL
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
//    public class LLInsert
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
//            LLInsert list = new LLInsert();
//            list.insert(70);
//            list.insert(30);
//            list.insert(56);
//            list.display();


//        }
//    }
//}
