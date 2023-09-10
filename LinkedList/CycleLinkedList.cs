public class Solution {
    public bool HasCycle(ListNode head) {
        ListNode slow = head, fast = head;

        while (fast != null && fast.next != null)
        {
            fast = fast.next.next;
            slow = slow.next;
            if (slow.Equals(fast)) return true;
        }
        return false;
    }
}