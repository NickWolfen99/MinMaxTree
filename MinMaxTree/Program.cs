using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace MinMaxTree
{
    public class Node
    {

        public int data;
        public Node left, right;

        public Node(int d)
        {
            data = d;
            left = right = null;
        }
    }

    public class BinarySearchTree
    {

        public static Node head;
  
        public Node insert(Node node, int data)
        {

            if (node == null)
            {
                return (new Node(data));
            }
            else
            {
 
                if (data <= node.data)
                {
                    node.left = insert(node.left, data);
                }
                else
                {
                    node.right = insert(node.right, data);
                }
                
                return node;
            }
        }

  
        public int MinVal(Node node)
        {
            Node current = node;
            
            while (current.left != null)
            {
                current = current.left;
            }
            return (current.data);
        }
        public int MaxVal(Node node)
        {
            Node current = node;

            while (current.right != null)
            {
                current = current.right;
            }
            return (current.data);
        }
        public static void Main(string[] args)
        {
            BinarySearchTree tree = new BinarySearchTree();
            Node root = null;
            root = tree.insert(root, 6);
            tree.insert(root, 2);
            tree.insert(root, 3);
            tree.insert(root, 12);
            tree.insert(root, 9);
            tree.insert(root, 5);

            Console.WriteLine($"Minimum value of Binary search tree is {tree.MinVal(root)}");
            Console.WriteLine($"Maximum value of Binary search tree is {tree.MaxVal(root)}");
            Console.ReadLine();
        }
    }
}  