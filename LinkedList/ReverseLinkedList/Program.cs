using Base;
using System;

namespace ReverseLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] head = { 1, 2, 3, 4, 5 };
            var nodeHead = new ListNode(head[head.Length - 1], null);
            for (int i = head.Length - 2; i > -1; i--)
            {
                ListNode new_node = new ListNode(head[i], nodeHead);
                nodeHead = new_node;
            }
            ListNode tnode = nodeHead;
            Helper.printList(tnode);

            nodeHead = ReverseList(nodeHead);
            Console.WriteLine("");

            tnode = nodeHead;
            Helper.printList(tnode);
        }

        public static ListNode ReverseList(ListNode head)
        {
            if (head == null)
                return null;
            ListNode dummy = new ListNode(head.val);
            while (head.next != null)
            {
                head = head.next;
                dummy = new ListNode(head.val, dummy);
            }

            return dummy;
        }
    }
}
