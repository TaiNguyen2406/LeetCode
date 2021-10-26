using Base;
using System;

namespace RemoveNthNodeFromEndofList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] head = { 1 };
            var nodeHead = new ListNode(head[head.Length - 1], null);
            for (int i = head.Length - 2; i > -1; i--)
            {
                ListNode new_node = new ListNode(head[i], nodeHead);
                nodeHead = new_node;
            }

            ListNode tnode = nodeHead;
            Helper.printList(tnode);

            nodeHead = RemoveNthFromEnd(nodeHead, 1);
            Console.WriteLine("");

            tnode = nodeHead;
            Helper.printList(tnode);
        }

        public static ListNode RemoveNthFromEnd(ListNode head, int n)
        {
            if (head == null)
                return null;

            ListNode dummy = new ListNode(),
                     node1 = dummy,
                     node2 = dummy;
            int i = 0;

            dummy.next = head;

            while (i < n)
            {
                node1 = node1.next;
                i++;
            }

            while (node1.next != null)
            {
                node1 = node1.next;
                node2 = node2.next;
            }

            node2.next = node2.next.next;

            return dummy.next;
        }

       
    }
}
