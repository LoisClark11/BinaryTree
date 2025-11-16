using System;

namespace BinaryTree
{
    internal class Program
    {
        class Node
        {
            public string Value;
            public Node Left;
            public Node Right;

            public Node(string value)
            {
                Value = value;
                Left = null;
                Right = null;
            }
        }

        class BinaryTree
        {
            public Node Root;
            public BinaryTree()
            {
                Root = new Node("10");

                Root.Left = new Node("5");
                Root.Left.Left = new Node("2");
                Root.Left.Left.Left = new Node("1");
                Root.Left.Left.Right = new Node("3");
                Root.Left.Right = new Node("7");


                Root.Right = new Node("40");
                Root.Right.Left = new Node("30");
                Root.Right.Left.Left = new Node("25");
                Root.Right.Left.Left.Left = new Node("20");
                Root.Right.Left.Left.Left.Left = new Node("15");
                Root.Right.Left.Left.Left.Left.Left = new Node("13");
                Root.Right.Left.Left.Left.Left.Left.Left = new Node("12");
                Root.Right.Left.Left.Left.Left.Right = new Node("17");

                Root.Right.Left.Right = new Node("35");
                Root.Right.Right = new Node("50");
                Root.Right.Right.Left = new Node("45");
                Root.Right.Right.Left.Left = new Node("42");
                Root.Right.Right.Left.Right = new Node("48");
                Root.Right.Right.Right = new Node("60");
                Root.Right.Right.Right.Left = new Node("55");

            }

            public void InOrderTraversal(Node node)//left -> root -> right
            {
                if (node == null) return;

                InOrderTraversal(node.Left);
                Console.Write(node.Value + " ");
                InOrderTraversal(node.Right);
            }

            public void PreOrderTraversal(Node node)//root -> left -> right
            {
                if (node == null) return;

                Console.Write(node.Value + " ");
                PreOrderTraversal(node.Left);
                PreOrderTraversal(node.Right);
            }

            public void PostOrderTraversal(Node node)//left -> root -> right
            {
                if (node == null) return;

                PostOrderTraversal(node.Left);
                PostOrderTraversal(node.Right);
                Console.Write(node.Value + " ");
            }
        }

        static void Main(string[] args)
        {
            BinaryTree tree = new BinaryTree();

            Console.WriteLine("In-Order Traversal:");
            tree.InOrderTraversal(tree.Root);
            Console.WriteLine();

            Console.WriteLine("Pre-Order Traversal:");
            tree.PreOrderTraversal(tree.Root);
            Console.WriteLine();

            Console.WriteLine("Post-Order Traversal:");
            tree.PostOrderTraversal(tree.Root);
            Console.WriteLine();
            Console.ReadLine();
        }
    }
}
