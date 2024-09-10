using Leetcode.DataStructure;

namespace Leetcode.Utils;

public static class Printer
{
    public static void PrintListNode(ListNode head)
    {
        Console.Write("[");
        while (head != null)
        {
            if (head.next == null)
                Console.Write(head.val);
            else
                Console.Write(head.val + ", ");
            head = head.next;
        }
        Console.WriteLine("]");
    }
}
