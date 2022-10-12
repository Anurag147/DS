using Two.Stacks.Array;

TwoStacks tw = new(6);
tw.PushOne(1);
tw.PushOne(2);
tw.PushTwo(3);
tw.PushTwo(4);
Console.WriteLine(tw.PopOne());
Console.WriteLine(tw.PopTwo());
Console.WriteLine(tw.PopOne());
Console.WriteLine(tw.PopTwo());
Console.WriteLine(tw.PopOne());
Console.WriteLine(tw.PopTwo());

Console.ReadLine();