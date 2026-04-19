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
 
/*
Para resolver este problema podemos utilizar tres punteros, 
un puntero que vaya por delante y guarde la referencia al proximo 
y los otros que vayan por detras y vayan haciendo swap, hasta que el 
ultimo puntero sea null 

*/

public class Solution {
    public ListNode ReverseList(ListNode head) {
        
        

        ListNode NodeLeft = null;
        ListNode NodeRight = head;



        while(NodeRight != null) {
            
           ListNode  SaveRef = NodeRight.next;

            NodeRight.next = NodeLeft;

            NodeLeft = NodeRight;

            NodeRight = SaveRef;

        }

        return NodeLeft;
    }
}
