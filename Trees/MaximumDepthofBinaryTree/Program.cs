using Base;
using System;

namespace MaximumDepthofBinaryTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] input = { 0, null, 6, null, null, 7,8};
            var root = new TreeNode(input[0].Value);
            TreeNode.generateTree(input, ref root, 0);
            TreeNode.inorder(root);
            var depth = MaxDepth(root);
            Console.WriteLine();
            Console.WriteLine(depth);
        }


        public static int MaxDepth(TreeNode root)
        {
            if (root == null) return 0;
            else
            {
                int lDepth = MaxDepth(root.left);
                int rDepth = MaxDepth(root.right);
                if (lDepth > rDepth)
                    return lDepth + 1;
                else
                    return rDepth + 1;
            }
        }
    }
}
