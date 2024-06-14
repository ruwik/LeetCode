namespace AddTwoNumbers {
    public class ListNode {
        public int val;
        public ListNode next;
        public ListNode(int val=0, ListNode next=null) {
            this.val = val;
            this.next = next;
        }
    }

    public class Solution {
        public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
            for (ListNode sumNode = l1; sumNode != null; sumNode = sumNode.next)
            {
                var l2Val = 0;
                if (l2 != null)
                {
                    l2Val = l2.val; 
                    l2 = l2.next;
                }
                var sum = sumNode.val + l2Val;
                var carry = 0;
                if (sum > 9)
                {
                    carry = 1;
                    sum -= 10;
                }
                sumNode.val = sum;

                if (l2 == null && carry != 1) continue;
                sumNode.next = sumNode.next == null ? new ListNode() : sumNode.next;
                sumNode.next.val += carry;
            }
            return l1;
        }
    }
}