//Create a BST with following values 10,20,30,17,23,27,35

using BST;

Node root = new Node(10);
root.Left = new Node(20);
root.Right = new Node(30);
root.Left.Left = new Node(17);
root.Left.Right = new Node(23);
root.Right.Left = new Node(27);
root.Right.Right = new Node(35);

//Program to search a node in BST
Console.WriteLine(IsPresentInTree(root,27));

//Program to insert a node in BST
//InsertInTree(root, 24);

//Program to find floor of a number
//If 10 is present in BST, then it is a Floor of 12 if it is smmaler than 12 and highest among all smaller elements
Node floor = FloorInTree(root,33); //Answer should be 30

Node ceiling = CeilingInTree(root, 33); //Answer should be 35

Console.ReadLine();

bool IsPresentInTree(Node root, int x)
{
    if(root==null)
    {
        return false;
    }
    if(root.Key == x) { return true; }
    else if (root.Key > x) { return IsPresentInTree((Node)root.Left,x); }
    else if(root.Key < x) { return IsPresentInTree((Node)root.Right,x); }
    return false;
}
Node InsertInTree(Node root, int v)
{
    if(root == null) { return new Node(v); }
    else if (root.Key < v)
    {
        root.Right = InsertInTree(root.Right, v);
    }
    else if (root.Key > v)
    {
        root.Left = InsertInTree(root.Left, v);
    }
    return root;
}
Node FloorInTree(Node root, int v)
{
    Node res = null;
    while (root != null)
    {
        if (root.Key > v) { root = root.Left; }
        else if(root.Key<v) { res = root;root = root.Right; }
        else { res = root; }
    }
    return res;
}
Node CeilingInTree(Node root, int v)
{
    Node res = null;
    while (root != null)
    {
        if (root.Key < v) { root = root.Right; }
        else if (root.Key > v) { res = root; root = root.Left; }
        else { res = root; }
    }
    return res;
}
