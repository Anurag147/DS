using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double.Linked.List
{
    public class LinkedList
    {
        public Node Head { get; set; }
        public Node Tail { get; set; }
        public int Counter { get; set; }

        public void AddFirst(int value)
        {
            Node newNode = new Node { Value = value };
            if (this.Counter == 0)
            {
                this.Head = this.Tail = newNode;
            }
            else
            {
                newNode.Next = this.Head;
                this.Head.Previous = newNode;
                this.Head = newNode;
            }
            this.Counter++;
        }
        public void AddLast(int value)
        {
            Node newNode = new Node { Value = value };
            if (this.Counter == 0)
            {
                this.Head = this.Tail = newNode;
            }
            else
            {
                newNode.Previous = this.Tail;
                this.Tail.Next = newNode;
                this.Tail = newNode;
            }
            this.Counter++;
        }
        public void RemoveFirst()
        {
            if (this.Counter == 0)
            {
                throw new Exception("List is already empty");
            }
            else
            {
                this.Head = this.Head.Next;
            }
            this.Counter--;
        }
        public void RemoveLast()
        {
            if (this.Counter == 0)
            {
                throw new Exception("List is already empty");
            }
            else
            {
                var currentNode = this.Head;
                while (currentNode.Next != this.Tail)
                {
                    currentNode=currentNode.Next;
                }
                currentNode.Next = null;
                this.Tail = currentNode;
            }
            this.Counter--;
        }
        public void Traverse()
        {
            var current = this.Head;
            while (current != null)
            {
                Console.WriteLine(current.Value);
                current = current.Next;
            }
        }
    }
}
