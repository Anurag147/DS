//Implementation of a Queue using a Linked List

using Queue;

QueueLinkedList q = new QueueLinkedList();
q.Enqueue(1);
q.Enqueue(2);
q.Enqueue(3);
q.Enqueue(4);
q.Enqueue(5);
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.WriteLine(q.Dequeue());
Console.ReadLine();