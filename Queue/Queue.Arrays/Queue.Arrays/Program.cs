using System;

namespace Queue.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            QueueArray<int> qrr = new QueueArray<int>();

            Console.WriteLine("************************Adding Items******************");
            qrr.Enqueue(4);
            qrr.Enqueue(3);
            qrr.Enqueue(2);
            qrr.Enqueue(1);
            qrr.Enqueue(0);
            qrr.Enqueue(9);
            qrr.Enqueue(10);

            Console.WriteLine("************************Removing Items******************");
            Console.WriteLine(qrr.DeQueue());
            Console.WriteLine(qrr.DeQueue());
            Console.WriteLine(qrr.DeQueue());
            Console.WriteLine(qrr.DeQueue());
            Console.WriteLine(qrr.DeQueue());

            Console.WriteLine("************************Showing Items******************");
            foreach (int item in qrr)
            {
                Console.WriteLine(item);
            }
            Console.ReadLine();
        }
    }
}
