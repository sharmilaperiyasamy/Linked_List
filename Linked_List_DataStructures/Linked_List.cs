using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Linked_List_DataStructures
{
    internal class Linked_List
    {
        Node head;
        public void Add(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
            {
                this.head = node;
            }
            else
            {
                Node temp = head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(data + " is inserted into the linked list.");
        }
        public void Display()
        {
            Node temp = this.head;
            if (temp == null)
            {
                Console.WriteLine("Linked List is empty.");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write(temp.data + "->");
                    temp = temp.next;
                }
            }
        }
        public void Append(int data)
        {
            Node node = new Node(data);
            if (this.head == null)
                this.head = node;
            else
            {
                Node temp = this.head;
                while (temp.next != null)
                {
                    temp = temp.next;
                }
                temp.next = node;
            }
            Console.WriteLine(data + " is added to the linked list.");
        }
        //uc4 insert at position
        public void InsertAtPosition(int position, int data)
        {
            Node newNode = new Node(data);
            if (position < 1)
                Console.WriteLine("Invalid position.");
            else if (position == 1)
            {
                newNode.next = this.head;
                head = newNode;
            }
            else
            {
                Node temp = this.head;
                for (int i = 1; i < position - 1; i++)
                {
                    temp = temp.next;
                }
                newNode.next = temp.next;
                temp.next = newNode;
            }
        }
        //uc5 delete the data at first position
        public void Delete()
        {
            if (this.head == null)
                Console.WriteLine("Linked List is Empty.");
            else
            {
                Console.WriteLine(this.head + " is removed from Linked List.");
                this.head = this.head.next;
            }
        }
        public void DeleteLast()
        {
            Node temp = this.head;
            if (temp == null)
                Console.WriteLine("Linked List is empty.");
            else if (temp.next == null)
                this.head = null;
            else
            {
                while (temp.next.next != null)
                {
                    temp = temp.next;
                }
                temp.next = null;
            }
        }
    }
}
