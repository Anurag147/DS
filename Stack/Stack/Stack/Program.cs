using Stack;

ArrayListStack asStack = new(5);

asStack.Push(1);
asStack.Push(2);
asStack.Push(3);
asStack.Push(4);
asStack.Push(5);

Console.WriteLine(asStack.Pop());
Console.WriteLine(asStack.Pop());
Console.WriteLine(asStack.Peek());


LinkedListStack lsStack = new();

lsStack.Push(1);
lsStack.Push(2);
lsStack.Push(3);
lsStack.Push(4);
lsStack.Push(5);

Console.WriteLine(lsStack.Pop());
Console.WriteLine(lsStack.Pop());
Console.WriteLine(lsStack.Peek());

Console.ReadLine();

