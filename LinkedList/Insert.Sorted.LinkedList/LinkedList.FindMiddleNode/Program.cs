//Program to find middle of a linked list
//In a tradition approach we will traverse the linked list twice and find a midpoint
//In this two pointer approach middle will be reached with the the help of one step pointer


//Initialize a linked List
using LinkedList.FindMiddleNode;

Node n = new Node(5);
n.Next = new Node(10);
n.Next.Next = new Node(20);
n.Next.Next.Next = new Node(25);
n.Next.Next.Next.Next = new Node(35);
n.Next.Next.Next.Next.Next = new Node(45);

Console.WriteLine(FindMiddle(n));
Console.ReadLine();

int FindMiddle(Node n)
{
    if(n == null)
    { return 0; }
    if(n.Next == null) { return n.Data; }

    Node slowPointer = n, fastPointer = n;
    while(fastPointer !=null && fastPointer.Next != null)
    {
        fastPointer = fastPointer.Next.Next;
        slowPointer = slowPointer.Next;
    }
    return slowPointer.Data;
}

Console.ReadLine();
