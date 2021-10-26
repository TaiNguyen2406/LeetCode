using System;

namespace Base
{
    public class ListNode
    {
        ListNode head;
        public int val;
        public ListNode next;
        public ListNode(int x) { val = x; }

        public ListNode(int _val = 0, ListNode _next = null) 
        { 
            val = _val;
            next = _next;
        }
        public ListNode() { }

        public void Push(int new_data)
        {
            ListNode new_node = new ListNode(new_data);
            new_node.next = head;
            head = new_node;
        }

        public void printList()
        {
            ListNode tnode = head;
            while (tnode != null)
            {
                Console.Write(tnode.val + " ");
                tnode = tnode.next;
            }
        }

        public  void DeleteNode(ListNode node)
        {
            ListNode temp = head, prev = null;

            if (temp != null && temp.val == node.val)
            {
                // Changed head
                head = temp.next;
                return;
            }

            // Search for the key to be
            // deleted, keep track of the
            // previous node as we need
            // to change temp.next
            while (temp != null &&
                   temp.val != node.val)
            {
                prev = temp;
                temp = temp.next;
                Console.Write(temp.val);
            }

            // If key was not present
            // in linked list
            if (temp == null)
                return;

            // Unlink the node from linked list
            prev.next = temp.next;
        }
    }

    public static class Helper
    {
        public static void printList(ListNode tnode)
        {
            while (tnode != null)
            {
                Console.Write(tnode.val + " ");
                tnode = tnode.next;
            }
        }
    }

}
