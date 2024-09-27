namespace _729._My_Calendar_I;

public class MyCalendarBinaryTree
{
    private readonly BinaryTree tree;

    public MyCalendarBinaryTree()
    {
        tree = new BinaryTree();
    }

    public bool Book(int start, int end)
    {
        if (start >= end) return false;
        bool isSuccess = tree.TryInsert(start, end);
        return isSuccess;
    }
}

public class BinaryTree
{
    private TreeNode? root = null;

    // Insert in correct order
    public bool TryInsert(int start, int end)
    {
        if (root == null)
        {
            root = new TreeNode(start, end);
            return true;
        }

        TreeNode? node = root;
        while (node != null)
        {
            if (node.start < end && start < node.end)
            {
                return false;
            }

            if (node.start >= end)
            {
                // traversal   
                if (node.left != null)
                {
                    node = node.left;
                }
                // insert
                else
                {
                    node.left = new TreeNode(start, end);
                    break;
                }
            }
            else if (node.end <= start)
            {
                // traversal    
                if (node.right != null)
                {
                    node = node.right;
                }
                // insert
                else
                {
                    node.right = new TreeNode(start, end);
                    break;
                }
            }
        }

        return true;
    }
    private class TreeNode
    {
        public int start;
        public int end;
        public TreeNode? left;
        public TreeNode? right;
        public TreeNode(int start, int end)
        {
            this.start = start;
            this.end = end;
            this.left = null;
            this.right = null;
        }
    }
}
