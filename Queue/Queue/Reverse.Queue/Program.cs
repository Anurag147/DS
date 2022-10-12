//Program to reverse a queue using a stack

Queue<int> myQueue = new Queue<int>();
myQueue.Enqueue(1);
myQueue.Enqueue(2);
myQueue.Enqueue(3);
myQueue.Enqueue(4);
myQueue.Enqueue(5);
myQueue.Enqueue(6);
myQueue.Enqueue(7);

Stack<int> myQueue3 = new Stack<int>();
while (myQueue.Count>0)
{
    myQueue3.Push(myQueue.Dequeue());
}
while(myQueue3.Count>0)
{
    myQueue.Enqueue(myQueue3.Pop());
}

//MyQueue is empty
Console.ReadLine();
