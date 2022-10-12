string matchText = "[[((({}))){}[[[]]]]]";
Console.WriteLine(IsParenthesisValid(matchText));
Console.ReadLine();

//Function to validate parenthesis using Stack DS
bool IsParenthesisValid(string matchText)
{
    Stack<char> stack = new Stack<char>();
    foreach (char c in matchText)
    {
        if(c == '(' || c == '[' || c == '{')
            stack.Push(c);
        else
        {
            if(stack.Count == 0)
                return false;
            else
            {
                if (isPair(stack.Peek(), c))
                    stack.Pop();
                else
                    return false;
            }
        }
    }
    if (stack.Count == 0)
        return true;
    else
        return false;
}
bool isPair(char a, char b)
{
    return (a == '(' && b == ')') || (a == '[' && b == ']') || (a == '{' && b == '}');
}