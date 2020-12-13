using System;
using System.Collections.Generic;

namespace TreeHeight
{
    class Program
    {
        static void Main(string[] args)
        {
			Node root = null;

			root = new Node(20);
			root.left = new Node(15);
			root.right = new Node(25);
			root.left.left = new Node(12);
			root.left.right = new Node(17);
			root.right.left = new Node(21);
			root.right.right = new Node(35);
			root.left.left.left= new Node(9);
			root.left.left.right = new Node(14);
			root.left.right.left = new Node(16);
			root.left.right.right = new Node(18);
			root.right.right.left = new Node(19);
			root.right.right.right = new Node(23);
			root.right.right.left = new Node(30);

			Console.Write("The height of the binary tree is h=" + height(root));
		}

		public static int height(Node root)
		{
			// Base case: empty tree has height 0
			if (root == null)
			{
				return 0;
			}

			// recur for left and right subtree and consider maximum depth
			return 1 + Math.Max(height(root.left), height(root.right));
		}
	}
}
