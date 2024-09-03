using System.Numerics;
var sln = new Solution();
ListNode l1 = new ListNode(3, null);
l1 = new ListNode(4, l1);
l1 = new ListNode(2, l1);
ListNode l2 = new ListNode(4, null);
l2 = new ListNode(6, l2);
l2 = new ListNode(5, l2);
ListNode result = sln.AddTwoNumbers(l1, l2);
while (result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}
public class Solution
{
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2)
    {
        return AddTwoNumbers(l1, l2, 0);
    }

    public ListNode AddTwoNumbers(ListNode node1, ListNode node2, int memo)
    {
        if (node1 == null && node2 == null && memo == 0) return null;
        int sum = (node1 != null ? node1.val : 0) + (node2 != null ? node2.val : 0) + memo;        
        return new ListNode(sum % 10, AddTwoNumbers(node1?.next, node2?.next, sum / 10));
    }

    // naive solution
    public ListNode AddTwoNumbers1(ListNode l1, ListNode l2)
    {
        BigInteger num1 = 0;
        for(BigInteger i = 1; l1 != null; i*=10)
        {
            num1 += l1.val * i;
            l1 = l1.next;
        }
        BigInteger num2 = 0;
        for (BigInteger i = 1; l2 != null; i *= 10)
        {
            num2 += l2.val * i;
            l2 = l2.next;
        }
        BigInteger sum = num1 + num2;

        ListNode list = null;
        foreach(char c in sum.ToString())
        {           
            list = new ListNode((c - '0'), list);
        }

        return list;
    }
}
public class ListNode
{
    public int val;
    public ListNode next;
    public ListNode(int value = 0, ListNode next = null)
    {
        this.val = value;
        this.next = next;
    }
}