using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SinglyLinkedList
{
    class Program
    {
        //My solution: these definitions needed to be moved here
        static string[] words = { "the", "actor", "jumped", "over", "the", "director" };
        static LinkedList<string> sentence = new LinkedList<string>(words);

        static void Main(string[] args)
        {
            //HomeMadeLinkedList();
            DemoLinkedListFeatures();
        }

        private static void DemoLinkedListFeatures()
        {
            //string[] words = { "the", "actor", "jumped", "over", "the", "director"};
            //LinkedList<string> sentence = new LinkedList<string>(words);
            Display(sentence, "The linked list values:");


            sentence.AddFirst("today");
            Display(sentence, "Test 1: Add 'today' to beginning of the list:");

            LinkedListNode<string> mark1 = sentence.First;
            sentence.RemoveFirst();
            sentence.AddLast(mark1);
            Display(sentence, "Test 2: Move first node to be the last node:");

            sentence.RemoveLast();
            sentence.AddLast("yesterday");
            Display(sentence, "Test 3: Change the last node to 'yesterday'.");

            mark1 = sentence.Last;
            sentence.RemoveLast();
            sentence.AddFirst(mark1);
            Display(sentence, "Test 4: Move the last node to be the first node:");

            sentence.RemoveFirst();
            LinkedListNode<string> current = sentence.FindLast("the");
            IndicateNode(current, "Test 5: Indicate last ocurance of 'the' node:");

            sentence.AddAfter(current, "old");
            sentence.AddAfter(current, "lazy");
            IndicateNode(current, "Test 6: Add 'lazy' and 'old' after 'the' node.");

            current = sentence.Find("actor");
            IndicateNode(current, "Test 7: Indicate the 'actor' node:");

            sentence.AddBefore(current, "quick");
            sentence.AddBefore(current, "skinny");
            IndicateNode(current, "Test 8: Add 'quick' and 'skinny' before 'actor' node:");

            Console.ReadLine();
        }
        //My solution
        private static void IndicateNode(LinkedListNode<string> current, string v)
        {
            string temp = current.Value;
            current.Value = "(" + current.Value + ")";
            
            Display(sentence, v);
            current.Value = temp;
        }
        //My solution
        private static void Display(LinkedList<string> sentence, string v)
        {
            Console.WriteLine(v);
            foreach (var word in sentence)
            {
                Console.Write(word + " ");
            }
            Console.WriteLine();
            Console.WriteLine();
        }


        #region HomeMadeLinkedList
        private static void HomeMadeLinkedList()
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
            Console.WriteLine("<" + data + ">");
        }
    } 
    #endregion
}
