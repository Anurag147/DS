//StockSpan problem - In this problem we are given an array of integers and we need to find number of consecutive elements which are lesser than the current element 
//The idea here is to use Stack DS and insert the index of larger number to it, while pushing the element we will traverse the stack

int[] arr = new int[] { 12, 10, 17, 16, 18, 20 };
Stack<int> stack = new Stack<int>();

//Stock Span Problem Solution
//Print first element index as -1

Console.WriteLine(1);
stack.Push(0);
for(int i = 1; i<arr.Length; i++)
{
    //We will pop the items either till empty of till index of last previous element

    while(stack.Count>0 && arr[stack.Peek()] <= arr[i])
    {
        stack.Pop();
    }
    Console.WriteLine(stack.Count == 0?i+1:i-stack.Peek());
    stack.Push(i);
}

//StockSpan problem - In this problem we are given an array of integers and we need to find number of consecutive elements which are lesser than the current element 
//The idea here is to use Stack DS and insert the index of larger number to it, while pushing the element we will traverse the stack

int[] arr1 = new int[] { 12, 10, 17, 16, 18, 20 };
Stack<int> stack1 = new Stack<int>();

//Print Previous Greater Element using Stock Span solution approach
//Print first element index as same

Console.WriteLine(-1);
stack1.Push(arr1[0]);
for (int i = 1; i < arr1.Length; i++)
{
    //We will pop the items either till empty of till index of last previous element

    while (stack1.Count > 0 && stack1.Peek() <= arr1[i])
    {
        stack1.Pop();
    }
    Console.WriteLine(stack1.Count == 0 ? -1 : stack1.Peek());
    stack1.Push(arr1[i]);
}

Stack<int> stack2 = new Stack<int>();
int[] arr2 = new int[] { 12, 10, 17, 16, 18, 20 };

//Print Next Greater Element using Stock Span solution approach
//Print last element index as -1 as nothing is greater than it

Console.WriteLine(-1);
stack1.Push(arr2[arr2.Length-1]);
for (int i = arr2.Length - 2; i >= 0; i--)
{
    //We will pop the items either till empty of till index of last previous element

    while (stack2.Count > 0 && stack2.Peek() <= arr2[i])
    {
        stack2.Pop();
    }
    Console.WriteLine(stack2.Count == 0 ? -1 : stack2.Peek());
    //This is currently printing in reverse order we can easily put this into array and print that array in serial order
    stack2.Push(arr2[i]);
}

Console.ReadLine();
