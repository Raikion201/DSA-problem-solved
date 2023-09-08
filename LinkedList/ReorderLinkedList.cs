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

    public void ReorderList(ListNode head) {
        if(head.next == null){
            return;
        }
            ListNode tail = head;
            var stack = new Stack<ListNode>();
            int count = -1;
            while(tail != null){
                stack.Push(tail);
                tail = tail.next;
                count++;
            }
            while(count > 0){

            ListNode tmp = head.next;
            head.next = stack.Pop();
            head.next.next = tmp;
            head = tmp;
            count -= 2;
            if(count == 1){
                head.next = stack.Pop();
            }

            }
            head.next = null;
        }


}