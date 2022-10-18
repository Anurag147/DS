namespace BST
{
    internal class Node
    {
        public int Key { get; set; }
        public Node Left { get; set; }
        public Node Right { get; set; }

        public Node(int key)
        {
            Key = key;
        }
    }
}
