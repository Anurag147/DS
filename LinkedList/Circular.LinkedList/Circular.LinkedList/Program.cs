using Circular.LinkedList;

//Create a circular linked list
Node head = CreateCircularLinkedList();

head = InsertNewNodeAtHead(head, new Node(9));

head = InsertNewNodeAtEnd(head, new Node(14));

head = DeleteHead(head);

head = DeleteFromIndex(head,3);

TraverseCircularLinkedList(head);
  
Node DeleteFromIndex(Node head, int index)
{
    if(index == 1)
    {
        return head.Next;
    }
    int i = 0;
    Node curr = head;
    while (i < index - 2)
    {
        curr = curr.Next;
        i++;
    }
    curr.Next = curr.Next.Next;
    return head;

}

Node DeleteHead(Node head)
{
    if (head == null || head.Next == null)
        return null;

    head.Value = head.Next.Value;
    head.Next = head.Next.Next;

    return head;
}

Node InsertNewNodeAtEnd(Node head, Node node)
{
    if (head == null)
        return node;

    node.Next = head.Next;
    head.Next = node;

    int t = head.Value;
    head.Value = node.Value;
    node.Value = t;

    return head.Next;
}

Node InsertNewNodeAtHead(Node head, Node node)
{
    if (head == null)
        return node;

    node.Next = head.Next;
    head.Next = node;

    int t = head.Value;
    head.Value = node.Value;
    node.Value = t;

    return head;
}

Console.ReadLine();

void TraverseCircularLinkedList(Node head)
{
    Node curr = head;
    if(curr == null)
        return;
    do
    {
        Console.WriteLine(curr.Value);
        curr = curr.Next;
    } while (curr != head);
}

Node CreateCircularLinkedList()
{
    Node head = new Node(10);
    head.Next = new Node(11);
    head.Next.Next = new Node(12);
    head.Next.Next.Next = new Node(13);
    head.Next.Next.Next.Next = head;
    return head;
}