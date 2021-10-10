using System;
using System.Collections;
using System.Collections.Generic;

namespace Queue.Arrays
{
    public class QueueArray<T>:IEnumerable<T>
    {
        public T[] Queue { get; set; }
        public int Head { get; set; }
        public int Tail { get; set; }
        public int ArrayLength = 5;
        public QueueArray()
        {
            Queue = new T[ArrayLength];
        }
        public void Enqueue(T obj)
        {
            if (Queue.Length == ArrayLength)
            {
                T[] newQueue = new T[ArrayLength * 2];
                Array.Copy(Queue, newQueue, ArrayLength);
                Queue = newQueue;
                ArrayLength *= 2;
            }
            Queue[Tail] = obj;
            Tail++;
        }
        public T DeQueue()
        {
            if (Tail-Head==0)
            {
                throw new Exception("The queue is already empty");
            }
            T dequeuedObj = Queue[Head];
            Head++;
            return dequeuedObj;
        }
        public IEnumerator<T> GetEnumerator()
        {
            for(int i = Head; i < Tail; i++)
            {
                yield return Queue[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
