using Leetcode.DataStructure;
using Leetcode.Utils;

int[] headNums = [1, 2, 3, 4, 5, 6, 7, 8, 9, 10];
int k = 3;
ListNode head = Converter.ArrayToListNode(headNums);

var sln = new Solution();
var parts = sln.SplitListToParts(head, k);

foreach (var part in parts)
{
    sln.PrintListNode(part);
}

public class Solution
{
    public ListNode[] SplitListToParts(ListNode head, int k)
    {
        ListNode[] parts = new ListNode[k];
        int count = CountOfListNode(head);
        int remain = count % k;
        int partSize = count / k;

        for (int i = 0; i < k; i++)
        {
            ListNode newPart = new ListNode();
            ListNode tail = newPart;

            int size = partSize;
            if (i < remain)
            {
                size = partSize + 1;
            }
            while (size > 0)
            {
                tail.next = new ListNode(head.val);
                tail = tail.next;
                head = head.next;
                size--;
            }
            parts[i] = newPart.next;
        }

        return parts;
    }

    private int CountOfListNode(ListNode head)
    {
        int count = 0;
        while (head != null)
        {
            count++;
            head = head.next;
        }
        return count;
    }

    public void PrintListNode(ListNode head)
    {
        Console.Write("[");
        while (head != null)
        {
            Console.Write(head.val);
            head = head.next;
        }
        Console.WriteLine("]");
    }
}