using System;
using System.Collections.Generic;

namespace Collections_Queue
{
    class Program
    {
        static void display(Queue<string> arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void display(Queue<int> arr)
        {
            foreach (var i in arr)
            {
                Console.WriteLine(i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = { 100, 200, 300 };
            string[] city = { "lahore", "karachi", "pindi" };

            var myQueue1 = new Queue<string>(city);
            var myQueue2 = new Queue<int>(arr);

            myQueue1.Enqueue("wamik");
            myQueue1.Enqueue("afaq");
            myQueue1.Enqueue("umair");
            myQueue1.Enqueue("askari");
            myQueue1.Enqueue("ihtisham");
            myQueue1.Enqueue("ihtisham");

            myQueue2.Enqueue(89);
            myQueue2.Enqueue(69);
            myQueue2.Enqueue(100);
            myQueue2.Enqueue(77);
            myQueue2.Enqueue(444);
            myQueue2.Enqueue(393);

            Console.WriteLine("--------------------------------------------------First iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(myQueue1);
            Console.WriteLine("Displaying Numbers");
            display(myQueue2);

            Console.WriteLine("--------------------------------------------------Searching--------------------------------------------------");
            Console.WriteLine(myQueue1.Peek());
            Console.WriteLine(myQueue2.Peek());

            myQueue1.Dequeue();
            myQueue1.Dequeue();
            myQueue2.Dequeue();

            Console.WriteLine("--------------------------------------------------Second iteration--------------------------------------------------");
            Console.WriteLine("Displaying Names");
            display(myQueue1);
            Console.WriteLine("Displaying Numbers");
            display(myQueue2);

            Console.WriteLine("--------------------------------------------------Info--------------------------------------------------");
            Console.WriteLine($"Stack 1 count: {myQueue1.Count}");
            Console.WriteLine($"Stack 2 count: {myQueue2.Count}");
            Console.WriteLine(myQueue1.Contains("wamik"));
            Console.WriteLine(myQueue1.Contains("hashim"));
        }
    }
}
