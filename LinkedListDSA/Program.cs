﻿namespace LinkedListDSA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListDemo demo = new LinkedListDemo();
            //demo.add(56);
            //demo.add(13);
            //demo.add(70);
            //demo.AddInReverse(90);
            //demo.AddInReverse(100);
            //demo.AddInReverse(70);
            //demo.RemoveFirstNode();
            //demo.RemoveLast();
            //demo.Size();
            //demo.InsertNodeAtSpecificPosition(0, 25);
            //demo.InsertNodeAtSpecificPosition(1, 58);
            //demo.InsertNodeAtSpecificPosition(2, 2);
            //demo.InsertNodeAtSpecificPosition(3, 250);
            //demo.DeleteNodeAtSpecificPosition(2);
            demo.Sorting(65);
            demo.Sorting(2);
            demo.Sorting(50);
            demo.Sorting(69);
            demo.Display();
            Console.ReadLine();
        }
    }
}