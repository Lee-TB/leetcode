using Leetcode.DataStructure;

namespace Leetcode.Utils;

public static class Converter
{
    public static TreeNode ArrayToTreeNode(int?[] nums)
    {
        Queue<TreeNode> queue = new Queue<TreeNode>();
        TreeNode root = new TreeNode(nums[0] ?? 0);
        queue.Enqueue(root);
        int i = 0;
        while (queue.Count > 0)
        {
            TreeNode node = queue.Dequeue();
            if (i + 1 < nums.Length && nums[i + 1] is int leftVal)
            {
                node.left = new TreeNode(leftVal);
                queue.Enqueue(node.left);
            }

            if (i + 2 < nums.Length && nums[i + 2] is int rightVal)
            {
                node.right = new TreeNode(rightVal);
                queue.Enqueue(node.right);
            }
            i += 2;
        }
        return root;
    }

    public static ListNode? ArrayToListNode(int[] nums)
    {
        ListNode? head = null;
        foreach (var num in nums.Reverse())
        {
            head = new ListNode(num, head);
        }
        return head;
    }
}
