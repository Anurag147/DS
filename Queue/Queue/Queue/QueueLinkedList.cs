namespace Queue
{
    internal class QueueLinkedList
    {
        public int Data { get; set; }
        public QueueLinkedList Next { get; set; }
        public QueueLinkedList Front { get; set; }
        public QueueLinkedList Rear { get; set; }

        public QueueLinkedList()
        {
            Front = Rear = null;
        }

        public void Enqueue(int data)
        {
            QueueLinkedList l = new QueueLinkedList();
            l.Data = data;
            if (Front == null)
            {
                Front = Rear = l;
            }
            else
            {
                Rear.Next = l;
                Rear = l;
            }
        }
        public int Dequeue()
        {
            if (Front == null)
                return 0;//This queuue is empty
            else
            {
                int data = Front.Data;
                Front=Front.Next;
                return data;
            }
        }
    }
}
