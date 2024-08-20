using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LinkedList
{     public class ListNode
    {
      public int val;
      public ListNode next;
      public ListNode(int val = 0, ListNode next = null)
        {
            this.val = val;
            this.next = next;
                 }

  }
    public class MergeTwoSortedLists
    {
        public ListNode MergeTwoLists(ListNode list1, ListNode list2)
        {   
            ListNode result = new ListNode(-1);
            ListNode current = result;

            ListNode p1 = list1;
            ListNode p2 = list2;

            while (p1 != null && p2 != null) 
            {
                if (p1.val <= p2.val)
                {
                    current.next = p1;
                    p1 = p1.next;
                }
                else 
                { 
                    current.next=p2;
                    p2 = p2.next;
                }
                current = current.next;
            }
            if (p1 != null)
            {
                current.next = p1;
            }
            else 
            {
                current.next = p2;
            }
            return result.next;
        }
    }
}
