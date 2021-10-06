using System;
using System.Collections;
using System.Collections.Generic;

namespace Stack.Arrays
{
    public class StackArray<T>:IEnumerable<T>
    {
        //Initialise an object array
        T[] objArray;
        int Count;
        int length = 5;
        public StackArray()
        {
            this.objArray = new T[length];
        }
        public void Push(T obj)
        {
            if (this.Count == this.length-1)
            {
                this.length *= 2;
                T[] newObjArray = new T[this.length];
                Array.Copy(objArray,newObjArray,this.Count+1);
                objArray = newObjArray;
            }
            objArray[this.Count] = obj;
            this.Count++;
        }
        public T Peek()
        {
            if (this.Count == 0)
            {
                throw new Exception("The stack is empty");
            }
            return objArray[this.Count-1];
        }
        public void Pop()
        {
            if (this.Count == 0)
            {
                throw new Exception("The stack is empty");
            }
            objArray[this.Count-1] = default;
            this.Count--;
        }

        public IEnumerator<T> GetEnumerator()
        {
            for (int i = this.Count-1; i >= 0; i--)
            {
                yield return this.objArray[i];
            }
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            return GetEnumerator();
        }
    }
}
