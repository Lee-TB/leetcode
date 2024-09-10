using Leetcode.DataStructure;
using Leetcode.Utils;

int[] nums = [18, 6, 10, 3];
ListNode head = Converter.ArrayToListNode(nums);

var sln = new Solution();
ListNode res = sln.InsertGreatestCommonDivisors(head);
Printer.PrintListNode(res);
public class Solution
{
    public ListNode InsertGreatestCommonDivisors(ListNode head)
    {
        ListNode currentNode = head;
        while (currentNode.next != null)
        {
            // find gcd
            int gcd = GCD(currentNode.val, currentNode.next.val);
            // create new node and insert it into linked list.
            ListNode newNode = new ListNode(gcd, currentNode.next);
            currentNode.next = newNode;
            currentNode = currentNode.next.next; // next two time to skip newNode
        }
        return head;
    }

    private int GCD(int a, int b)
    {
        if (b == 0) return a;
        return GCD(b, a % b);
    }
}