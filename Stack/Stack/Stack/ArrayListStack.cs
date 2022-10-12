
namespace Stack
{
    internal class ArrayListStack
    {
        public List<int> List { get; set; }
        int top = -1;
        public ArrayListStack(int items)
        {
            List = new List<int>();
        }
        public void Push(int number)
        {
                top++;
                List.Add(number);

        }
        public int Pop()
        {
            if (top == -1)
            {
                Console.WriteLine("This stack is empty.");
                throw new Exception("This stack is empty."); ;
            }
            else
            {
                int number = (int)List[top];
                List.RemoveAt(top);
                top--;
                return number;
            }
        }
        public int Peek()
        {
            if(top == -1)
            {
                Console.WriteLine("This stack is empty.");
                throw new Exception("This stack is empty."); 
            }
            else
            {
                return (int)List[top];
            }
        }
        public bool IsEmpty()
        {
            return top == -1?true:false;
        }
    }
}
