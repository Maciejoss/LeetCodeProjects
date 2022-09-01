public class ListNode {
      public int val;
      public ListNode next;
      public ListNode(int val=0, ListNode next=null) {
          this.val = val;
          this.next = next;
      }
  }
 
public class Solution {

    public ListNode OddEvenList(ListNode head) {
                
        if(head==null||head.next==null)return head;    
    
        ListNode lastodd=head;
        ListNode lasteven=head.next;
        ListNode firsteven = lasteven;
        
        head.next=head.next.next;

        while(true){

            if(lasteven.next!=null){
                lastodd.next=lasteven.next;
                lastodd=lasteven.next;
            	} else{break;}

            if(lastodd.next!=null){
                lasteven.next = lastodd.next;
                lasteven=lastodd.next;
            }else{lasteven.next=null;break;}

        }

        lastodd.next=firsteven;
        
        return head;
    }
}