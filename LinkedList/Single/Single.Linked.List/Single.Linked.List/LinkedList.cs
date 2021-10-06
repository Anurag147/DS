using System;

namespace Single.Linked.List
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Counter { get; set; }

        public void AddFirst(int value)
        {
            Node newNode = new Node { Value = value };

            if (Counter == 0)
            {
                this.Head = this.Tail = newNode;
            }
            else
            {
                newNode.Next = this.Head;
                this.Head = newNode;
            }
            Counter++;
        }

        public void AddLast(int value)
        {
            Node newNode = new Node { Value = value };

            if (Counter == 0)
            {
                this.Head = this.Tail = newNode;
            }
            else
            {
                this.Tail.Next = newNode;
                this.Tail = newNode;
            }
            Counter++;
        }

        public void RemoveFirst()
        {
            if (Counter == 0)
            {
                throw new System.Exception("This list is already empty");
            }
            else
            {
                this.Head = this.Head.Next;
            }
            Counter--;
        }

        public void RemoveLast()
        {
            if (Counter == 0)
            {
                throw new System.Exception("This list is already empty");
            }
            else
            {
                Node currentNode = this.Head;
                while (currentNode.Next != this.Tail)
                {
                    currentNode = currentNode.Next;
                }
                currentNode.Next = null;
            }
            Counter--;
        }
        public void Traverse()
        {
            Node currentNode = this.Head;
            while (currentNode != null)
            {
                Console.WriteLine(currentNode.Value);
                currentNode = currentNode.Next;
            }
        }
    }
}
