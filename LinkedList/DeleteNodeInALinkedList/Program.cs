using Base;
using System;

namespace DeleteNodeInALinkedList
{
    class Program
    {
        static ListNode head;
        static void Main(string[] args)
        {
            //head = new ListNode();
            //head.Push(7);
            //head.Push(1);
            //head.Push(3);
            //head.Push(2);
            //Console.WriteLine("\nCreated Linked list is:");
            //head.printList();
            //var deleteNode = new ListNode(3);
            //head.DeleteNode(deleteNode);

            //Console.WriteLine("\nLinked List after " +
            //                  "Deletion at position 4: ");
            //head.printList();
            int[] head = { 4, 5, 1, 9 };
            var nodeHead = new ListNode(head[head.Length - 1]);
            nodeHead.next = null;
            ListNode deleteNode = new ListNode();
            for (int i = head.Length - 2; i > -1; i--)
            {
                ListNode new_node = new ListNode(head[i]);
                new_node.next = nodeHead;
                if (i == 1)
                {
                    deleteNode = new_node;
                }
                nodeHead = new_node;
            }

            ListNode tnode = nodeHead;
            Helper.printList(tnode);

            DeleteNodeDirectly(deleteNode);
            Console.WriteLine("");

            tnode = nodeHead;
            Helper.printList(tnode);
        }

        public static void DeleteNodeDirectly(ListNode node)
        {
            node.val = node.next.val;
            node.next = node.next.next;
        }

    }

}
