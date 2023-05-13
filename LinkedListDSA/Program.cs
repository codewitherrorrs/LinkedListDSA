namespace LinkedListDSA
{
    public class Program
    {
        public static void Main(string[] args)
        {
            LinkedListDemo demo = new LinkedListDemo();
            //demo.add(56);
            //demo.add(13);
            //demo.add(70);
            demo.AddInReverse(90);
            demo.AddInReverse(100);
            demo.AddInReverse(70);
            //demo.RemoveFirstNode();
            demo.RemoveLast();
            demo.Display();
            Console.ReadLine();
        }
    }
}