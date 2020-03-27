using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            SinglyLinkedList myList = new SinglyLinkedList();
            myList.InsertFirst(100);
            myList.InsertFirst(50);
            myList.InsertFirst(42);
            myList.InsertFirst(77);
            myList.DisplayList();
            myList.InsertLast(9999);
            myList.DeleteFirst();
            myList.DisplayList();
        }
    }

    public class SinglyLinkedList
    {
        private Node first;
        public bool IsEmpty()
        {
            return first == null;
        }

        public void InsertFirst(int data)
        {
            Node newNode = new Node();
            newNode.data = data;
            newNode.next = first;
            first = newNode;
        }

        public Node DeleteFirst()
        {
            Node temp = first;
            first = first.next;
            return temp;
        }

        public void DisplayList()
        {
            Console.WriteLine("List (first -- last) ");
            Node current = first;
            while (current != null)
            {
                current.DisplayNode();
                current = current.next;
            }
            Console.WriteLine();
        }

        public void InsertLast(int data)
        {
            Node current = first;
            while (current.next != null)
            {
                current = current.next;
            }

            Node newNode = new Node();
            newNode.data = data;
            current.next = newNode;
        }
    
    }

    public class Node
    {
        public int data;
        public Node next;

        public void DisplayNode()
        {
            Console.WriteLine("<" + data + "");
        }
    }
}
