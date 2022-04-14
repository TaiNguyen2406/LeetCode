using System;
using Base;

namespace MergeTwoSortedLists
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] node1 = { 2 };
            var nodeHead1 = new ListNode(node1[node1.Length - 1], null);
            for (int i = node1.Length - 2; i > -1; i--)
            {
                ListNode new_node = new ListNode(node1[i], nodeHead1);
                nodeHead1 = new_node;
            }
            int[] node2 = { 3};
            var nodeHead2 = new ListNode(node2[node2.Length - 1], null);
            for (int i = node2.Length - 2; i > -1; i--)
            {
                ListNode new_node = new ListNode(node2[i], nodeHead2);
                nodeHead2 = new_node;
            }

            ListNode tnode = nodeHead1;
            Helper.printList(tnode);

            tnode = nodeHead2;
            Helper.printList(tnode);

            var nodeHead = MergeTwoLists(nodeHead1, nodeHead2);
            Console.WriteLine("");

            tnode = nodeHead;
            Helper.printList(tnode);
        }

        static ListNode MergeTwoLists(ListNode l1, ListNode l2)
        {
            if (l1 == null)
                return l2;
            if (l2 == null)
                return l1;
             
            // Pick either a or b, and recur
            if (l1.val < l2.val)
            {
                l1.next = MergeTwoLists(l1.next, l2);
                return l1;
            }
            else
            {
                l2.next = MergeTwoLists(l1, l2.next);
                return l2;
            }
        }
    }
}
