using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BST
{
    internal class BinarySearchTree
    {
        private TreeNode Root { get; set; }
        public void Insert(int value)
        {
            Root = InsertRecursive(Root, value);
        }
        private TreeNode InsertRecursive(TreeNode currentNode, int value)
        {
            if (currentNode == null)
                return new TreeNode(value);
            if (value < currentNode.Value)
                currentNode.Left = InsertRecursive(currentNode.Left, value);
            else if (value > currentNode.Value)
                currentNode.Right = InsertRecursive(currentNode.Right, value);
            return currentNode;
        }
        public bool Search(int value)
        {
            return SearchRecursive(Root, value);
        }
        private bool SearchRecursive(TreeNode currentNode, int value)
        {
            if (currentNode == null)
                return false;
            if (value == currentNode.Value)
                return true;
            return value < currentNode.Value
            ? SearchRecursive(currentNode.Left, value)
            : SearchRecursive(currentNode.Right, value);
        }
        public int SearchMin()
        {
            TreeNode current = Root;
            while (current.Left != null)
            {
                current = current.Left;
            }
            return Root.Value;
        }
        public int SearchFloor(int x)
        {
            int floor = -1;  
            TreeNode current = Root;  

            while (current != null)
            {
                if (current.Value == x)
                {
                    return current.Value; 
                }
                else if (current.Value > x)
                {
                   
                    current = current.Left;
                }
                else
                {
                    
                    floor = current.Value;
                    current = current.Right;  
                }
            }
            return floor;  
        }



    }
}
