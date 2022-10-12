//Generate numbers using two digits 5 and 6 using a queue
//Example: 5,6,55,56,65,66,555,556...

Queue<string> myQueue = new Queue<string>();
myQueue.Enqueue("5");
myQueue.Enqueue("6");

for(int i =0; i<12; i++)
{
    Console.WriteLine(myQueue.Peek());
    string curr = myQueue.Dequeue();
    myQueue.Enqueue(curr+"5");
    myQueue.Enqueue(curr + "6");
}
Console.ReadLine();