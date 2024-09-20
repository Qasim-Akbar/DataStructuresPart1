using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataStructuresPart1
{
    internal class Node
    {
        public int Data;
        public Node Left;
        public Node Right;

        public void DisplayNode()
        {
            Console.WriteLine(Data + " ");
        }
    }

    internal class BinarySearchTree
    {
        public Node root;

        public BinarySearchTree()
        {
            this.root = null;
        }

        public void Insert(int i)
        {
            Node newNode = new Node();
            newNode.Data = i;
            if (root is null) root = newNode;
            else
            {
                Node current = root;
                Node parent;
                while (true)
                {
                    parent = current;
                    if(i<parent.Data)
                    {
                        //Go left
                        current = current.Left;
                        if(current is null)
                        {
                            parent.Left = newNode;
                            break;
                        }
                    }
                    else
                    {
                        //Go Right
                        current = current.Right;
                        if (current is null)
                        {
                            parent.Right = newNode;
                            break;
                        }
                    }
                }
            }
        }

        public int CheckMaxLevel()
        {
            int level = 0;
            if (root is not null) 
            {
                level += 1;
            }
            return level;
        }

        public int CheckMaxLevel(Node theRoot)
        {

        }

        //Low to high (Asc Order)
        public void InOrder(Node theRoot)
        {
            if(theRoot is not null)
            {
                InOrder(theRoot.Left);
                theRoot.DisplayNode();
                InOrder(theRoot.Right);
            }
        }

        public void PreOrder(Node theRoot)
        {
            if (theRoot is not null)
            {
                theRoot.DisplayNode();
                PreOrder(theRoot.Left);
                PreOrder(theRoot.Right);
            }
        }

        public void PostOrder(Node theRoot)
        {
            if (theRoot is not null)
            {
                PreOrder(theRoot.Left);
                PreOrder(theRoot.Right);
                theRoot.DisplayNode();
            }
        }

        public int FindMin()
        {
            Node current = root;
            while(current.Left is not null)
                current = current.Left;
            return current.Data;
        }

        public int FindMax()
        {
            Node current = root;
            while (current.Right is not null)
                current = current.Right;
            return current.Data;
        }

        public Node Find(int key)
        {
            Node current = root;
            while (current.Data != key)
            {
                if (key < current.Data)
                    current = current.Left;
                else current = current.Right;
                if (current is null) return null;
            }
            return current;
        }
    }
}
