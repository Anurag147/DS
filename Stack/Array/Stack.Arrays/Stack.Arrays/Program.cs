using System;

namespace Stack.Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            StackArray<int> stArray = new StackArray<int>();
            stArray.Push(1);
            stArray.Push(2);
            stArray.Push(3);
            stArray.Push(4);
            stArray.Push(5);
            stArray.Push(6);
            stArray.Push(7);

            Console.WriteLine(stArray.Peek());

            stArray.Pop();

            foreach(int obj in stArray)
            {
                Console.WriteLine(obj);
            }

            Console.ReadLine();
        }
    }
}
