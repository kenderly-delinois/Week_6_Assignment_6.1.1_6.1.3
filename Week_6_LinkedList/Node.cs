using System;
using System.Collections.Generic;
using System.Linq;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Week_6_LinkedList
{
    internal class Node // 2 parts: data, next
    {
        public int data; // data
        public Node next; // address / ref link of next node

        public Node(int val, Node next)
        {
            this.data = val;
            this.next = next;
        }
    }
    class CustomList
    {
        // Never give access to the head of the list
        private Node head;
        private Node tail;
        private int size;


        public int Size
        {
            get { return size; }
        }

        public CustomList()
        {
            this.head = null;
            this.tail = null;
            this.size = 0;
        }

        public bool IsEmpty()
        {
            return this.size == 0;
        }

        public void AddFirst(int val)
        {
            Node newNode = new Node(val, null); // new node creation
            if (IsEmpty())
            {
                this.head = newNode;
                this.tail = newNode;

            }
            else
            {
                newNode.next = this.head; // point to the next link of newNode to the existing head
                this.head = newNode; // update the head
            }
            size++;
        }

        public void Display()
        {
            Node temp = head;
            if (IsEmpty()) { Console.WriteLine("List is empty"); }
            else
            {
                while (temp != null)
                {
                    if (temp.next != null)
                    {
                        Console.Write(temp.data + "------->");
                    }
                    else
                    {
                        Console.WriteLine(temp.data); // last

                    }
                    temp = temp.next;
                }
            }
        }
        public void AddLast(int val)
        {
            Node newNode = new Node(val, null);
            if (IsEmpty())
            {
                this.head = newNode;
            }
            else
            {
                this.tail.next = newNode;
            }
            size++;
        }
        public int RemoveFirst()
        {
            if (IsEmpty()) { return -1; }

            else
            {
                int val = head.data;
                head = head.next;
                this.size--;

                if (IsEmpty()) // there was only 1 node from the list and which was removed
                {
                    tail = null;
                }
                return val;
            }
        }

        public int RemoveLast()
        {
            if (IsEmpty()) { return -1; }
            else
            {
                Node temp = head;
                int i = 1;

                while (i < size - 1) // got to second last null
                {
                    temp = temp.next;
                    i++;
                }
                tail = temp; // Tail is the second to last null
                // next 2 steps are to retuen data from last node

                temp = temp.next;
                int val = temp.data;
                tail.next = null;
                return val;
            }
        }

        public bool Search(int val, out int index)
        {
                Node temp = head;
                int i = 1;
                while (temp != null)
                {
                    if (temp.data == val)
                    {
                        index = i;
                        return true;
                    }
                    temp = temp.next;
                    i++;
                } 
                index = i;
            return false;
            }
        }
    }
