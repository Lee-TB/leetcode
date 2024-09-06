var sln = new Solution();
int[] nums = [1, 2, 3];
ListNode head = null;
head = new ListNode(1, head);
head = new ListNode(1, head);
head = new ListNode(1, head);
head = new ListNode(1, head);
head = new ListNode(1, head);
head = new ListNode(2, head);
head = new ListNode(2, head);
head = new ListNode(2, head);
head = new ListNode(2, head);
head = new ListNode(3, head);
head = new ListNode(5, head);
head = new ListNode(4, head);
head = new ListNode(3, head);
head = new ListNode(2, head);
head = new ListNode(2, head);
head = new ListNode(2, head);
head = new ListNode(2, head);
head = new ListNode(1, head);
head = new ListNode(1, head);
head = new ListNode(1, head);
head = new ListNode(1, head);
ListNode result = sln.ModifiedList(nums, head);
while (result != null)
{
    Console.WriteLine(result.val);
    result = result.next;
}

public class Solution
{
    public ListNode ModifiedList(int[] nums, ListNode head)
    {
        // create HashSet for increase loopkup speed
        HashSet<int> numsSet = new HashSet<int>();
        foreach (int num in nums)
        {
            numsSet.Add(num);
        }

        // remove number at head
        while (numsSet.Contains(head.val))
        {
            head = head.next;
        }

        // remove any remainning number
        ListNode looper = head;
        while (looper.next != null)
        {
            if (numsSet.Contains(looper.next.val))
            {
                looper.next = looper.next.next; // remove by jumping
            }
            else
            {
                looper = looper.next;
            }
        }
        return head;
    }
}

public class ListNode
{
    public int val;
    public ListNode next;

    public ListNode(int val = 0, ListNode next = null)
    {
        this.val = val;
        this.next = next;
    }
}