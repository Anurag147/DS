// Program to insert a new node in a sorted linked list
//This program has a O(N) time complexity

using Insert.Sorted.LinkedList;

//Initialize a linked List
Node n = new Node(5); 
n.Next =new Node(10);
n.Next.Next = new Node(20);
n.Next.Next.Next = null;

n = InsertInSortedLinkedList(n,new Node(25));

Console.ReadLine();

Node InsertInSortedLinkedList(Node head, Node node)
{
    if(head == null)
    {
        return node;
    }
    if(node.Data < head.Data)
    {
        node.Next = head;
        return node;
    }
    Node curr = head;
    while(curr!=null && curr.Next !=null && curr.Next.Data < node.Data)
    {
        curr = curr.Next;
    }
    node.Next = curr.Next;
    curr.Next = node;
    return head;
}