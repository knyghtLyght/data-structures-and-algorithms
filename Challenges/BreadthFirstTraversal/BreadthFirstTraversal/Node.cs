using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal
{
    public class Node
    {
        public Node Next { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
        public int Value { get; set; }
    }
}
