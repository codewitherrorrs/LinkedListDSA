﻿using System;
using System.Collections.Generic;
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

        //Add Data from Reverse Order.
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

        //RemoveAtNode
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
