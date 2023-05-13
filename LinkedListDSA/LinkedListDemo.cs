using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedListDSA
{
    public class LinkedListDemo
    {
        public Node head;
        //Add Data from last.
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
            Console.WriteLine("{0} LinkedList : ", node.data);
        }

        //Add Data from Reverse Order / First.
        public void AddInReverse(int data)
        {
            Node newNode = new Node(data);
            if (this.head == null)
            {
                this.head = newNode;
            }
            else
            {
                Node temp = head;
                head = newNode;
                head.next = temp;
            }
            //Console.WriteLine($"Data : {newNode.data}");
        }

        //Remove Node from first.
        public void RemoveFirstNode()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            head = head.next;
        }

        //Remove the lastNode
        public void RemoveLast()
        {
            if (head == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            if (head.next == null)
            {
                head = null;
            }
            Node lastNode = this.head;
            while (lastNode.next.next != null)
            {
                lastNode = lastNode.next;
            }
            lastNode.next = null;
        }

        //Size of the LinkedList.
        public void Size()
        {
            Node temp = head;
            int count = 0;
            if (temp == null)
            {
                Console.WriteLine("Linked List is Empty");
            }
            while (temp != null)
            {
                Console.WriteLine($"{temp.data} ");
                temp = temp.next;
                count++;
            }
            Console.WriteLine($"The Size of LinkedList : {count} ");
        }

        //Insert Data from the given position.
        public void InsertNodeAtSpecificPosition(int position,int data)
        {
            Console.WriteLine($"Position is entered : {position} and Data is : {data}");
            if(position == 0)
            {
                AddInReverse(data);
                return;
            }
            Node newNode = new Node(data);
            Node temp = head;
            int count = 1;
            while(count < position-1)
            {
                temp = temp.next;
                count++;
            }
            newNode.next = temp.next;
            temp.next = newNode; 
        }

        //Delete Node or Data from the given Position.
        public void DeleteNodeAtSpecificPosition(int position)
        {
            Console.WriteLine($"Position : {position}");
            if(position == 1)
            {
                head = head.next;
            }
            else
            {
                Node current = head;
                Node previous = null;
                int count = 1;
                while(count <= position-1)
                {
                    previous = current;
                    current = current.next;
                    count++;
                }
                previous.next = current.next;

            }
        }

        //For Printing.
        public void Display()
        {
            Node temp = head;
            if (temp == null)
            {
                Console.WriteLine("LinkedList is Empty");
            }
            else
            {
                while (temp != null)
                {
                    Console.Write($"{temp.data} -> ");
                    temp = temp.next;
                }
                Console.Write("NULL");
            }
        }
    }
}
