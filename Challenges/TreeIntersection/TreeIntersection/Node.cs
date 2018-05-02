using System;
using System.Collections.Generic;
using System.Text;

namespace TreeIntersection
{
    public class Node
    {
        public string Value { get; set; }
        public string Key { get; set; }
        public Node Next { get; set; }
        public Node LeftChild { get; set; }
        public Node RightChild { get; set; }
    }
}
