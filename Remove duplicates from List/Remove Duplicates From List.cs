/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode DeleteDuplicates(ListNode head) {
        var duplicatesMap = new Dictionary<int, bool>(); 
        var current = head;
        ListNode previous = null;
        if(head == null || head.next == null)
        {
            return head;
        }

        while(current != null)
        {
            if(duplicatesMap.ContainsKey(current.val))
            {
                if(current.next != null)
                {
                    previous.next = current.next;
                }
                else
                {
                    previous.next = null;
                }
            }
            else
            {
                previous = current;
                duplicatesMap[current.val] = true;
            }

            current = current.next;
        
        }
        return head;
    }
}
