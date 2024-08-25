internal class Program
{
    private static void Main(string[] args)
    {
        TreeNode root = new TreeNode(1,
        left: null,
        right: new TreeNode(2,
        left: new TreeNode(3,
            left: null,
            right: null),
        right: null));
            var sln = new Solution();
            var list = sln.PostorderTraversal(root);
            foreach (var item in list)
                Console.WriteLine(item);
    }
}

public class Solution
{
    public IList<int> PostorderTraversal(TreeNode root)
    {
        IList<int> list = new List<int>();
        Helper(root, list);
        return list;
    }

    private void Helper(TreeNode root, IList<int> list)
    {
        if (root is TreeNode)
        {
            Helper(root.left, list);
            Helper(root.right, list);
            list.Add(root.val);
        }
    }
}

public class TreeNode
{
    public int val;
    public TreeNode left;
    public TreeNode right;
    public TreeNode(int value, TreeNode left, TreeNode right)
    {
        this.val = value;
        this.left = left;
        this.right = right;
    }
}