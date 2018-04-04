using System;
using System.Collections.Generic;
using System.Text;

namespace fifo_animal_shelter
{
    public class Node
    {
        public Node Next { get; set; }
        public Animal Value { get; set; }
    }
}
