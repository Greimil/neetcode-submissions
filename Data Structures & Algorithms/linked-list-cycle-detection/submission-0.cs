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
    public bool HasCycle(ListNode head)
    {

        var dict = new Dictionary<ListNode, bool>();

        while (head != null)
        {

            if (dict.ContainsKey(head) && dict[head] == true)
            {
                return true;
            }
            else
            {
                dict[head] = true;
                head = head.next;
            }


        }


        return false;

    }
}
