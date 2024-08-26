var sln = new Solution();

var root = new Node(val: 1, children: [
        new Node(3, [
                new Node(5),
                new Node(6),
        ]),
        new Node(2),
        new Node(4),
    ]);

var list = sln.Postorder(root);

foreach (var item in list)
{
    Console.Write(item + ", ");
}

public class Solution
{
    private List<int> list = new List<int>();
    public IList<int> Postorder(Node root)
    {
        if (root == null) return list;
        Helper(root);
        return list;
    }

    private void Helper(Node node)
    {
        if (node is null) return;

        foreach (var child in node.children)
        {
            Helper(child);
        }

        list.Add(node.val);
    }
}

public class Node
{
    public int val;
    public IList<Node> children;

    public Node()
    {

    }

    public Node(int val)
    {
        this.val = val;
    }

    public Node(int val, IList<Node> children) : this(val)
    {
        this.children = children;
    }
}