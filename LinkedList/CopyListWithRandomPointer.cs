/*
// Definition for a Node.
public class Node {
    public int val;
    public Node next;
    public Node random;

    public Node(int _val) {
        val = _val;
        next = null;
        random = null;
    }
}
*/

public class Solution {
    public Node CopyRandomList(Node head) {
        if(head == null){
            return head;
        }
        var map = new Dictionary<Node,Node> ();
        Node curr1 = head;
        Node copy = new Node(head.val);
        Node curr2 = copy;
        map[curr1] = curr2;
        curr1 = curr1.next;
        while( curr1 != null ){
            Node newNode = new Node(curr1.val);
            curr2.next = newNode;
            map[curr1] = newNode;
            curr2 = curr2.next;
            curr1 = curr1.next;
        }
        curr1 = head;
        curr2 = copy;
        while(curr1 != null){
            var random = curr1.random != null ? map[curr1.random] : null;
            curr2.random = random;
            curr1 = curr1.next;
            curr2 = curr2.next;
        }
        return copy;
    }
}