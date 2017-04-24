using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
//Task
//The height of a binary search tree is the number of edges 
//    between the tree's root and its furthest leaf.
//    You are given a pointer, root, pointing to the root of a binary search tree.
//    Complete the getHeight function provided in your editor 
//    so that it returns the height of the binary search tree.

//Sample Input

//7
//3
//5
//2
//1
//4
//6
//7
//Sample Output

//3
namespace Day22BinarySearchTree
{
    class Node
    {
        public Node left, right;
       

        public int data;
        public Node(int data)
        {
            this.data = data;
            //multiple assignment below
            //assigns null to right, then right to left
            left = right = null;
        }

       


       
    }

    class Program
    {

        private static int getHeight(Node root)
        {
            if (root == null)
            {
                return -1;
            }

            //Console.WriteLine("Height of left" + getHeight(root.left));
            return 1 + Math.Max(getHeight(root.left), getHeight(root.right));
        }

      



        static Node insert(Node root, int data)
        {
            if (root == null)
            {
                return new Node(data);
            }
            else
            {
                Node cur;
                if (data <= root.data)
                {
                    cur = insert(root.left, data);
                    root.left = cur;
                }
                else
                {
                    cur = insert(root.right, data);
                    root.right = cur;
                }
                return root;
            }
        }
        static void Main(string[] args)
        {

            Node root = null;
            int T = Int32.Parse(Console.ReadLine());
            while (T-- > 0)
            {
                int data = Int32.Parse(Console.ReadLine());
                root = insert(root, data);
            }

         
            //in above example answer should be 3
            int height = getHeight(root);
           Console.WriteLine("The height is {0}", height);
           // Console.WriteLine("There are {0}", countNodes(root));
            Console.ReadLine();
        }
    }
}
