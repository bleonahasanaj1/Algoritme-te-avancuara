using System;
using System.Collections.Generic;
using System.Text;

namespace TreeHeight
{
	public class Node
	{
		public int key;
		public Node left;
		public Node right;

		public Node(int key)
		{
			this.key = key;
			this.left = this.right = null;
		}
	}
}
