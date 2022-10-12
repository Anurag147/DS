namespace Two.Stacks.Array
{
    internal class TwoStacks
    {
        public int StackOneTop { get; set; }
        public int StackTwoTop { get; set; }
        public int[] StackArray { get; set; }
        public TwoStacks(int length)
        {
            StackArray = new int[length];
            StackOneTop = -1;
            StackTwoTop = length;
        }
        public void PushOne(int num)
        {
            if(StackOneTop<StackTwoTop-1)
            {
                StackOneTop++;
                StackArray[StackOneTop] = num;
            }
            else
            {
                Console.WriteLine("First stack is full");
            }
        }
        public void PushTwo(int num)
        {
            if (StackTwoTop > StackOneTop + 1)
            {
                StackTwoTop--;
                StackArray[StackTwoTop] = num;
            }
            else
            {
                Console.WriteLine("Second stack is full");
            }
        }
        public int PopOne()
        {
            if (StackOneTop >= 0)
            {
                int num = StackArray[StackOneTop];
                StackOneTop--;
                return num;
            }
            else
            {
                Console.WriteLine("This stack is empty");
                return -1;
            }
        }
        public int PopTwo()
        {
            if (StackTwoTop < StackArray.Length)
            {
                int num = StackArray[StackTwoTop];
                StackTwoTop++;
                return num;
            }
            else
            {
                Console.WriteLine("This stack is empty");
                return -1;
            }
        }
    }
}
