using Leetcode.DataStructure;
using Leetcode.Utils;

var sln = new Solution();

int[] nums = [1, 4, 2, 6, 8];
ListNode head = Converter.ArrayToListNode(nums);

int?[] numsTree = [1, 4, 4, null, 2, 2, null, 1, null, 6, 8, null, null, null, null, 1, 3];
TreeNode root = Converter.ArrayToTreeNode(numsTree);

Console.WriteLine(sln.IsSubPath(head, root));

public class Solution
{
    // create a list to store all path from root to leaves
    private List<string> paths = new List<string>();
    public bool IsSubPath(ListNode head, TreeNode root)
    {
        // LinkedList to to string elements
        string listPath = "";
        while (head != null)
        {
            listPath += head.val;
            head = head.next;
        }

        // Find all paths
        DFS(root, "");

        return paths.Any(path => path.Contains(listPath));
    }

    private void DFS(TreeNode node, string path)
    {
        if (node.left == null && node.right == null) paths.Add(path + node.val.ToString()); // is leaves
        if (node.left != null) DFS(node.left, path + node.val.ToString());
        if (node.right != null) DFS(node.right, path + node.val.ToString());
    }    
}
