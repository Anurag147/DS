using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Double.Linked.List
{
    class Program
    {
        static void Main(string[] args)
        {
            LinkedList lst = new LinkedList();
            lst.AddFirst(10);
            lst.AddFirst(11);
            lst.AddLast(12);
            lst.AddLast(13);
            lst.RemoveFirst();
            lst.RemoveLast();
            lst.Traverse();
            Console.ReadLine();
        }
    }
}
