using System;

namespace Base
{
    public class TreeNode
    {
        public int val;
        public TreeNode left;
        public TreeNode right;
        public TreeNode(int val = 0, TreeNode left = null, TreeNode right = null)
        {
            this.val = val;
            this.left = left;
            this.right = right;
        }
        //        i

        //    /     \
        //(2*i+1)   (2*i+2)
        //        Array1 = [1, 3, 2, 5]

        // Tree 1
        //    1
        //   / \
        //  3   2
        // /   
        //5   
        //Array2 = [2,1,3,null,4,null,7]
        //        Tree 2
        //      2
        //     / \
        //    1   3
        //      \   \
        //      4   7   
        public static void generateTree(int?[] arr, ref TreeNode node, int i)
        {
            if (node != null)
            {
                if (2 * i + 1 < arr.Length)
                {
                    if (arr[2 * i + 1] == null)
                    {
                        node.left = null;
                    }
                    else
                    {
                        node.left = new TreeNode(arr[2 * i + 1].Value);
                    }
                    generateTree(arr, ref node.left, 2 * i + 1);
                }

                if (2 * i + 2 < arr.Length)
                {
                    if (arr[2 * i + 2] == null)
                    {
                        node.right = null;
                    }
                    else
                    {
                        node.right = new TreeNode(arr[2 * i + 2].Value);
                    }
                    generateTree(arr, ref node.right, 2 * i + 2);
                }
            }

        }

        public static void inorder(TreeNode node)
        {
            if (node != null)
            {
                inorder(node.left);
                Console.Write(node.val + " ");
                inorder(node.right);
            }
        }
    }
}
