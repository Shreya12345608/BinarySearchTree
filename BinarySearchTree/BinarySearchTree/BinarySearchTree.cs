using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace BinarySearchTree
{
    
    class BinarySearchTree<T> where T : IComparable
    {
        T NodeData;
        //property For Left tree and right tree
        public BinarySearchTree<T> leftTree { get; set; }
        public BinarySearchTree<T> rightTree { get; set; }
        bool result = false;
        int leftCount = 0;
        int rightCount = 0;
            
        public BinarySearchTree(T NodeData)
        {
            // val is the key or the value that
            // has to be added to the data part
            this.NodeData = NodeData;
            // Left and right child for node
            // will be initialized to null
            this.leftTree = null;
            this.rightTree = null;
        }
        /// <summary>
        /// insert the item
        /// </summary>
        /// <param name="item"></param>
        public void Insert(T item)
        {
            T currentNodeValue = this.NodeData;
            if ((currentNodeValue.CompareTo(item)) > 0)
            {
                if (this.leftTree == null)
                    this.leftTree = new BinarySearchTree<T>(item);
                else
                    this.leftTree.Insert(item);
            }
            else
            {
                if (this.rightTree == null)
                    this.rightTree = new BinarySearchTree<T>(item);
                else
                    this.rightTree.Insert(item);
            }
        }
        /// <summary>
        /// For display the BST
        /// </summary>
        public void Display()
        {
            if (this.leftTree != null)
            {
                this.leftCount++;
                this.leftTree.Display();
            }
            Console.WriteLine(this.NodeData.ToString());
            if (this.rightTree != null)
            {
                this.rightCount++;
                this.rightTree.Display();
            }
            
        }
        /// <summary>
        /// size of the binary tree
        /// </summary>
        public void Size()
        {
            Console.WriteLine("Size of Binary Serach Tree " + (1 + leftCount + rightCount));
        }
    }
}
