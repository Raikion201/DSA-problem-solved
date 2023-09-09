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
    public ListNode RemoveNthFromEnd(ListNode head, int n) {
        ListNode curr1 = head;
        ListNode curr2 = head;
        int size = 0;
        while(curr1 != null){
            curr1 = curr1.next;
            size++;
        }
        if(n == size){
           return  head.next;
        }
        int pos = 0;
        while(curr2 != null){
            pos++;
            if(pos == (size - n )){
                ListNode tmp = curr2.next;
                curr2.next = tmp.next;
                tmp.next = null;
            }
            curr2 = curr2.next;

        }
        return head;
    }
}