﻿namespace Circular.LinkedList
{
    internal class DoubleNode
    {
        public int Value { get; set; }
        public DoubleNode Previous { get; set; }
        public DoubleNode Next { get; set; }

        public DoubleNode(int value)
        {
            Value = value;
        }
    }
}
