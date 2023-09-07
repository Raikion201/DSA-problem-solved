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
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode head,tmp;
        if( list1 == null ){
            return list2;
            }else if(list2 == null){
                return list1;
            }
        if(list1.val <= list2.val){
            head = list1;
            list1 = list1.next;
        }else{
            head = list2;
            list2 = list2.next;
        }
        tmp = head;
        while( list1 != null && list2 != null ){
            if(list1.val <= list2.val  ){
                head.next = list1;
                list1 = list1.next;
            }else if(list1.val > list2.val){
                head.next = list2;
                list2 = list2.next;
            }
                head = head.next;
        }

            if( list1 == null ){
                head.next = list2;
            }else
                head.next = list1;

        return tmp;

    }
}