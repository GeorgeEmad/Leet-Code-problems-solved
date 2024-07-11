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
    public ListNode MiddleNode(ListNode head) {
        ListNode currentNode = head;
        int totalCount = 0;
        while(currentNode != null)
        {
            currentNode = currentNode.next;
            totalCount++;
        }

        ListNode result = head;
        int middle = (totalCount/2) + 1 ;
        for(int i= 0; i< middle-1;i++)
        {
            result = result.next;
        }
        return result;
    }
}