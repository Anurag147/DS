//Print 'N'th node from end of linked list using two pointer approach
using LinkedList.LastNnode;

Node n = new Node(5);
n.Next = new Node(10);
n.Next.Next = new Node(20);
n.Next.Next.Next = new Node(25);
n.Next.Next.Next.Next = new Node(35);
n.Next.Next.Next.Next.Next = new Node(45);
Console.WriteLine(PrintNode(n,3));
Console.ReadLine();

int PrintNode(Node head,int nodePosition)
{
    if (head == null)
        return 0;

    Node first = head, second = head;

    for(int i = 0; i<nodePosition; i++)
    {
        if (first == null)
            return 0;
        first = first.Next;
    }

    while (first != null)
    {
        first = first.Next;
        second= second.Next;
    }
    return second.Data;
}
