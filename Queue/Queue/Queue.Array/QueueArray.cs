using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

//Queue Array using circular approach
namespace Queue.Array
{
    internal class QueueArray
    {
        public int[] Q { get; set; }
        public int Size { get; set; }
        public int Front { get; set; }
        public int Rear { get; set; }

        public QueueArray(int size)
        {
            Size = 0;
            Front = 0;
            Rear = 0;
            Q = new int[size];
        }
        public void Enqueue(int data)
        {
            if (Size >= Q.Length+1)
            {
                return;
            }
            Rear = (Front+Size) % Q.Length;
            Q[Rear]=data;
            Size++; 
        }
        public int Dequeue()
        {
            if(Size==-1)
                return -1;//This queue is empty
            else
            {
                int returnData = Q[Front];
                Front = (Front + 1) % Q.Length;
                Size--;
                return returnData;
            }
        }
    }
}
