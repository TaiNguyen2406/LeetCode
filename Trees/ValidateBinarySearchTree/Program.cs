using System;
using Base;

namespace ValidateBinarySearchTree
{
    class Program
    {
        static void Main(string[] args)
        {
            int?[] input = { 2,1,3 };
            var root = new TreeNode(input[0].Value);
            TreeNode.generateTree(input, ref root, 0);
            TreeNode.inorder(root);
            var res = IsValidBST(root);
            Console.WriteLine();
            Console.WriteLine(res);
        }

        public static bool IsValidBST(TreeNode root, int? low =null, int?  high=null)
        {
            if (root == null) 
                return true;
            if ((low != null && root.val <= low) || (high != null && root.val >= high))
            {
                return false;
            }
           
            if (!IsValidBST(root.left, low,root.val)) 
                return false;
            if (!IsValidBST(root.right,root.val,high)) 
                return false;
            return true;
        }
    }
}
