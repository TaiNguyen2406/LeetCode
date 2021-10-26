using Base;
using System;

namespace PalindromeLinkedList
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] head = { 1,2,3,4,3,2,1};
            var nodeHead = new ListNode(head[head.Length - 1], null);
            for (int i = head.Length - 2; i > -1; i--)
            {
                ListNode new_node = new ListNode(head[i], nodeHead);
                nodeHead = new_node;
            }
            ListNode tnode = nodeHead;
            Helper.printList(tnode);

            var result = IsPalindrome(nodeHead);
            Console.WriteLine(result);
        }

        public static bool IsPalindrome(ListNode head)
        {
            ListNode slow = head, fast = head, prev, temp;
            while (fast != null && fast.next != null)
            {
                slow = slow.next;
                fast = fast.next.next;
            }
            prev = slow;
            slow = slow.next;
            prev.next = null;
            while (slow != null)
            {
                temp = slow.next;
                slow.next = prev;
                prev = slow;
                slow = temp;
            }
            fast = head;
            slow = prev;
            while (slow != null)
            {
                if (fast.val != slow.val) return false;
                fast = fast.next;
                slow = slow.next;
            }
            return true;
        }


    }
}
