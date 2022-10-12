// See https://aka.ms/new-console-template for more information

using Doubly.LinkedList;

Node? head = null;

head = InsertAtBegining(head,10);
head = InsertAtBegining(head, 20);

head = InsertAtEnd(head, 30);
head = InsertAtEnd(head, 40);

//head = ReverseLinkedList(head);

head = RemoveFirstNode(head);
head = RemoveLastNode(head);

Console.ReadLine();

//Function to insert a new node to the start of a doubly linked list
Node? InsertAtBegining(Node? head, int v)
{
    Node node = new Node(v);
    if(head == null)
    {
        return node;
    }
    node.Next = head;
    head.Previous = node;
    return node;
}

//Function to insert a new node at the end of a doubly linked list
Node? InsertAtEnd(Node? head, int v)
{
    Node node = new Node(v);
    if (head == null)
    {
        return node;
    }
    Node curr = head;
    while (curr.Next != null)
    {
        curr=curr.Next;
    }
    curr.Next = node;
    node.Previous = curr;
    return head;
}

//Function to reverse linked list

Node? ReverseLinkedList(Node head)
{
    if(head == null || head.Next == null)
    {
        return head;
    }

    Node previous = null;
    Node current = head;

    while (current != null)
    {
        previous = current.Previous;
        current.Previous = current.Next;
        current.Next = previous;
        current = current.Previous;
    }
    return previous.Previous;
}

//Function to remove head of a list

Node? RemoveFirstNode(Node head)
{
    if (head == null)
        return null;
    if (head.Next == null)
        return null;

    Node curr = head.Next;
    curr.Previous = null;
    return curr;
}

//Function to remove head of a list

Node? RemoveLastNode(Node head)
{
    if (head == null)
        return null;
    if (head.Next == null)
        return null;

    Node curr = head;
    while (curr.Next != null)
    {
        curr = curr.Next;
    }
    curr.Previous.Next = null;
    return head;
}