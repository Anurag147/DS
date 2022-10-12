using System;
namespace Stack
{
    internal class LinkedListNode
    {
        public int Value { get; set; }
        public LinkedListNode Next { get; set; }
        public LinkedListNode(int value)
        {
            Value = value;
        }
    }
    internal class LinkedListStack
    {
        LinkedListNode head;
        public LinkedListStack()
        {
            head = null;
        }
        public void Push(int value)
        {
            LinkedListNode node = new LinkedListNode(value);
            if(head == null)
            {
                head = node;
            }
            node.Next = head;
            head = node;
        }
        public int Pop()
        {
            if(head == null)
            {
                Console.WriteLine("Stack is empty");
                throw new Exception("");
            }
            else
            {
                int num = head.Value;
                head = head.Next;
                return num;
            }
        }
        public int Peek()
        {
            if (head == null)
            {
                Console.WriteLine("Stack is empty");
                throw new Exception("");
            }
            else
            {
                int num = head.Value;
                return num;
            }
        }
        public bool IsEmpty()
        {
            return head == null ? true : false;
        }
    }
}
