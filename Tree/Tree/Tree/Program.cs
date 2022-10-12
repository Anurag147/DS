//Initialise a Tree 
using System.Collections;
using System.Collections.Generic;
using Tree;

Node root = new(10);

//Form Left SubTree
root.Left = new(20);
root.Left.Left = new(30);
root.Left.Right = new(40);

//Form Right SubTree
root.Right = new(50);
root.Right.Left = new(60);
root.Right.Right = new(70);

//Function to Print this Inorder
//Inorder traversal is LHR so the output will be: 30,20,40,10,60,50,70
PrintInorder(root);
Console.WriteLine(" :InOrder");

//Function to Print this PreOrder
//Inorder traversal is HLR so the output will be: 10,20,30,40,50,60,70
PrintPreOrder(root);
Console.WriteLine(" :PreOrder");

//Function to Print this PostOrder
//Inorder traversal is LRH so the output will be: 30,40,20,60,70,50,10
PrintPostOrder(root);
Console.WriteLine(" :PostOrder");

//Print Height of Binary Tree
//Height of binary tree is calculated by recursively travelling to left and right part of the tree
//And then finding the maximum of depth of left and right part and adding 1 to the result
Console.WriteLine("Height of this binary tree is: " + PrintHeightOfTree(root));

//Print elements at kth depth of a Binary Tree
//kth depth of a Binary Tree is calculated by recursively travelling to left and right part of the tree
//And then finding the index of depth of left and right part
PrintElementsAtDepth(root,2);

//Level order traversal of a tree, in this approach the the tree is traversed at every level
LevelOrderTraversalInOneLine(root);

//Level order traversal of a tree, in this approach the the tree is traversed at every level
LevelOrderTraversalInMultipleLine(root);

Console.WriteLine();
Console.WriteLine(ReturnNumberOfNodes(root));

Console.WriteLine(ReturnMaxValueNode(root));

Console.ReadLine();

void PrintInorder(Node root)
{
    if(root == null)
    {
        return;
    }
    //Go Left
    PrintInorder(root.Left);
    Console.Write(root.Value + " ");
    PrintInorder(root.Right);
}
void PrintPreOrder(Node root)
{

    if (root == null)
    {
        return;
    }

    Console.Write(root.Value + " ");
    //Go Left
    PrintPreOrder(root.Left);
    PrintPreOrder(root.Right);
}
void PrintPostOrder(Node root)
{

    if (root == null)
    {
        return;
    }

    PrintPostOrder(root.Left);
    PrintPostOrder(root.Right);
    Console.Write(root.Value + " ");
    //Go Left
}
int PrintHeightOfTree(Node root)
{
    if (root == null)
    {
        return 0;
    }
    return Math.Max(PrintHeightOfTree(root.Left), PrintHeightOfTree(root.Right))+1;
}
void PrintElementsAtDepth(Node root, int v)
{
    if (root == null)
    {
        return;
    }
    if (v == 0)
    {
        Console.WriteLine(root.Value);
    }
    else
    {
        PrintElementsAtDepth(root.Left, v - 1);
        PrintElementsAtDepth(root.Right, v - 1);
    }
}
void LevelOrderTraversalInOneLine(Node root)
{
    Queue<Node> queue = new Queue<Node>();
    queue.Enqueue(root);

    while (queue.Count > 0)
    {
        Node node = queue.Dequeue();
        Console.Write(node.Value+ " ");
        if (node.Left != null)
            queue.Enqueue(node.Left);
        if(node.Right!=null)
            queue.Enqueue(node.Right);
    }
    //In the end the queue will become empty and all elements are printed at level order
}
void LevelOrderTraversalInMultipleLine(Node root)
{
    Queue<Node> queue = new();
    queue.Enqueue(root);
    queue.Enqueue(null);
    Console.WriteLine();

    while (queue.Count > 1)
    {
        var node = queue.Dequeue();
        if (node == null)
        {
            Console.WriteLine();
            queue.Enqueue(null);
            continue;
        }

        Console.Write(node.Value + " ");
        if (node.Left != null)
            queue.Enqueue(node.Left);
        if (node.Right != null)
            queue.Enqueue(node.Right);
    }
    //In the end the queue will become empty and all elements are printed at level order
}
int ReturnNumberOfNodes(Node root)
{
    if(root == null)
    {
        return 0;
    }
    else
    {
        return 1 + ReturnNumberOfNodes(root.Left) + ReturnNumberOfNodes(root.Right);
    }
}
int ReturnMaxValueNode(Node root)
{
    if (root == null)
    {
        return int.MinValue;
    }
    else
    {
        return Math.Max(root.Value, Math.Max(ReturnMaxValueNode(root.Left), ReturnMaxValueNode(root.Right)));
    }
}

