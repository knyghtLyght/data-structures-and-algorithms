# Binary tree with Distance

Trees are a non-linear data structure based on a hierarchical structure. Starting from the Root node a tree connects nodes with links/edges. A parent node can have one or more nodes descending from it, called child-nodes, but traditionally will not know its own parent node. A non-root parent node is also called an internal node. A node that has no child-nodes is called a leaf-node.

A Binary tree is a tree where each node has a maximum of two child-nodes
A Binary search tree is a binary tree that has it nodes sorted by value. A node with a lesser value than the current node will always be it's left child and one with a greater value will always be it's right child.

## Challenge

Implement a binary tree with a function that calculates the distance between two nodes on the tree.

## Solution

The Insert method is a recursive method that checks which side of the current node to place the insert value. It then checks if the current node has a node in appropriate direction. If a node exists it makes a recursive call with that node as our new current node. If no node exists it creates one with the insert value and exits.

Provided post and pre order traversals.

The Find Node method takes in a root node and a target value. It first checks if the node is null indicating we have traversed the entire tree without finding our target OR if the value of our node is our target value. If either condition is true it will return the current node. Since we know the structure of or nodes in a BST we then determine the path to take to our next node by checking if it is larger or smaller than the value of our current node. Once the path is chosen we make a recursive call to continue the search.

The Find Distance method determines the target nodes distance from the given root using the same logic as Find Node but keeps track of the number of links on the way to the target node.

The Find Node Iterative method was implemented for practice. It uses the same logic as Find Node but uses a queue instead of recursive calls.

The LCA method takes a root node and two target values and returns the node that is the Lowest Common Ancestor for those nodes. It first checks if the root is null if so we return null. The next check is if the root value = either of our target values. If it does we return our root. We then make two recursive calls representing our left and right search. It then checks if left and right are not null. If both are not null we return out node as the LCA. If not it will return the non-null node it received.

The Node Distance method takes two target values and returns the distance between them. It uses the LCA method to find the smallest subtree containing the two target values. It then uses the Find Distance method to determine the distance from the LCA for each target. It then adds both target distances together to find the distance between the nodes.
