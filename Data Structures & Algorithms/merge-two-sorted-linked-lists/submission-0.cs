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
 
/* Aca lo que se me ocurre es lo siguiente:
Como no conocemos la longitud de las listas para determinar cual es mas 
larga, lo que podemos hacer es simplemente recorrerlas a las dos con un bucle while
hasta que lleguemos a un nodo que sea null.

en el primer bucle ir comparando el valor de los nodos, para determinar 
donde iria cada nodo, podemos simplemente comparar el valor actual de los dos nudos 
tanto el de la lista1 y lista2, en caso de ser iguales simplemente agregarlo justo despues 

hacer el mismo proceso para la segunda lista. 

Nota: es importante guardar la referencia a los siguientes nodos antes de hacer cualquier 
operacion, y una vez hecha la operacion entonces actualizar el nodo correspondiente 
a a la variable que apunta al sigueinte nodo, para esto tendremos que tener dos 
variables que guarden las referencias de ambas listas en cada uno de los bucles. 

*/

public class Solution {
    public ListNode MergeTwoLists(ListNode list1, ListNode list2) {
        ListNode dummy = new ListNode();
        ListNode tail = dummy;

        while(list1 != null && list2 != null) {
            
            if(list1.val < list2.val) {
                tail.next = list1;
                list1 = list1.next;

            }  else {

                tail.next = list2;
                list2 = list2.next;
            }

            tail = tail.next;

        }
    
        tail.next =  list1 ?? list2;

        return dummy.next;
    
    }
}