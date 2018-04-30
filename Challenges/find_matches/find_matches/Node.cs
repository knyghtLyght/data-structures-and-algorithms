using System;
using System.Collections.Generic;
using System.Text;

namespace Find_matches
{
    public class Node
    {
        public int Value { get; set; }
        public Node Next { get; set; }
        public List<Node> Children { get; set; }

        public Node()
        {
            Children = new List<Node>();
        }
    }
}
