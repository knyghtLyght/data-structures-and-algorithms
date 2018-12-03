using System;
using System.Collections.Generic;
using System.Text;

namespace BreadthFirstTraversal
{
    public class MyTree
    {
        public Node Root { get; set; }
        private string TraversalString { get; set; }

        public MyTree()
        {
            Root = null;
        }

        public void Add(Node add)
        {
            //Not a full tree implementation 
        }

        public string InOrder()
        {
            TraversalString = "";
            inOrderHelper(Root);
            return TraversalString;
        }
        public void inOrderHelper(Node node)
        {
            if (node.LeftChild != null)
            {
                inOrderHelper(node.LeftChild);
            }
            TraversalString = $"{TraversalString} {node.Value}";
            if (node.RightChild != null)
            {
                inOrderHelper(node.RightChild);
            }
        }

        //Depth first traversals
        public string PreOrder()
        {
            TraversalString = "";
            PreOrderHelper(Root);
            return TraversalString;
        }

        public void PreOrderHelper(Node node)
        {
            TraversalString = $"{TraversalString} {node.Value}";
            if (node.LeftChild != null)
            {
                PreOrderHelper(node.LeftChild);
            }
            if (node.RightChild != null)
            {
                PreOrderHelper(node.RightChild);
            }
        }

        public string PostOrder()
        {
            TraversalString = "";
            PostOrderHelper(Root);
            return TraversalString;
        }

        public void PostOrderHelper(Node node)
        {
            if (node.LeftChild != null)
            {
                PostOrderHelper(node.LeftChild);
            }
            if (node.RightChild != null)
            {
                PostOrderHelper(node.RightChild);
            }
            TraversalString = $"{TraversalString} {node.Value}";
        }
    }
}
